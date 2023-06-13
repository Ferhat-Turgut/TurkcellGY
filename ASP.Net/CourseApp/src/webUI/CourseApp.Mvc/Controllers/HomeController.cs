using CourseApp.DataTransferObjects.Responses;
using CourseApp.Mvc.CacheTools;
using CourseApp.Mvc.Models;
using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace CourseApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICourseService _courseService;
        private readonly IMemoryCache _memoryCache;
        public HomeController(ILogger<HomeController> logger,ICourseService courseService,IMemoryCache memoryCache)
        {
            _logger = logger;
            _courseService = courseService;
            _memoryCache = memoryCache;
        }

        public IActionResult Index(int pageNo=1,int? categoryId=null)
        {
            IEnumerable<CourseDisplayResponse> courses = GetCoursesMemCacheOrDb(categoryId);

            var courseCount = courses.Count();
            var coursePerPage = 4;
            var totalPage = Math.Ceiling((decimal)courseCount / coursePerPage);
            //ViewBag.TotalPage = totalPage;
            //ViewBag.activePge = pageNo;

            var pagingInfo = new PagingInfo
            {
                ActivePage = pageNo,
                ItemPerPage = coursePerPage,
                TotalItems = courseCount
            };

            var paginatedCourses = courses.OrderBy(c => c.Id)
                                          .Skip((pageNo - 1) * coursePerPage)
                                          .Take(coursePerPage)
                                          .ToList();

            var model = new PaginationCourseViewModel
            {
                Courses = paginatedCourses,
                PagingInfo = pagingInfo
            };

            return View(model);
        }

        private IEnumerable<CourseDisplayResponse> GetCoursesMemCacheOrDb(int? categoryId)
        {
            //eğer cache de varsa cache den kullanır, yoksa kaynaktan çekip cache e atar.

            if (!_memoryCache.TryGetValue("allCourses",out CacheDataInfo cacheDataInfo))
            {
                var options = new MemoryCacheEntryOptions()
                                  .SetSlidingExpiration(TimeSpan.FromMinutes(1))
                                  .SetPriority(CacheItemPriority.Normal);
                cacheDataInfo = new CacheDataInfo
                {
                    CacheTime = DateTime.Now,
                    Courses = _courseService.GetCourseDisplayResponses() 
                };;
                _memoryCache.Set("allCourses", cacheDataInfo, options);
            }

            _logger.LogInformation($"{cacheDataInfo.CacheTime.ToLongTimeString()} anındaki cache'i görüntülüyorsunuz.");
            return categoryId == null ? cacheDataInfo.Courses :
                                        _courseService.GetCourseByCategory(categoryId.Value);
        }
        [ResponseCache(Duration =70,VaryByQueryKeys =new[] {"id"},Location =ResponseCacheLocation.Client)]
        public IActionResult Privacy(int id)
        {
            ViewBag.Id = id;
            ViewBag.DateTime = DateTime.Now;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}