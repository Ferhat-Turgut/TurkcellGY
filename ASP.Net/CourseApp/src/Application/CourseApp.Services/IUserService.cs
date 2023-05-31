using CourseApp.Entities;

namespace CourseApp.Services
{
    public interface IUserService
    {
        User validateUser(string userName, string password); 
   
    }
}
