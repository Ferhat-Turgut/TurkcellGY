using CourseApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CourseApp.API.Filters
{
    public class IsExistsFilter : IAsyncActionFilter
    {
        private readonly ICourseService courseService;

        public IsExistsFilter(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var IdParameterIsExist = context.ActionArguments.ContainsKey("id");
            if (!IdParameterIsExist)
            {
                context.Result = new BadRequestObjectResult(new { 
                                 message = $"{context.ActionDescriptor.DisplayName} action'u , id parametresi içermelidir." });
            }
            else
            {
                var id =(int)context.ActionArguments["id"];
                if (await courseService.CourseIsExist(id)) 
                {
                    await next.Invoke();
                }
                else
                {
                    context.Result = new NotFoundObjectResult(new
                    {
                        message = $"{id}'li kurs bulunamadı."
                    });
                }
            }
        }
    }
}
