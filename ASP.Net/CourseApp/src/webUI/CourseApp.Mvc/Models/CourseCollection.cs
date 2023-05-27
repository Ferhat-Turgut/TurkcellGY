using CourseApp.DataTransferObjects.Responses;
using CourseApp.Entities;

namespace CourseApp.Mvc.Models
{
    public class CourseCollection
    {
        public List<CourseItem> CourseItems  { get; set; }=new List<CourseItem>();
        public void ClearAll()=> CourseItems.Clear();
        public decimal TotalCoursePrice() => CourseItems.Sum(c=>(decimal)c.Course.Price * c.Quantity);
        public int TotatCourseCount() => CourseItems.Sum(c=> c.Quantity);

        public void AddNewCourse(CourseItem courseItem)
        {
            var exist = CourseItems.FirstOrDefault(c=>c.Course.Id==courseItem.Course.Id);
            if (exist!=null) 
            {
                exist.Quantity += courseItem.Quantity;
            }
            else
            {
                CourseItems.Add(courseItem);
            }
        }
    }

    public class CourseItem 
    {
        public CourseDisplayResponse Course { get; set; }
        public int Quantity { get; set; }
        public bool? ApplyCoupon { get; set; }
    };
}
