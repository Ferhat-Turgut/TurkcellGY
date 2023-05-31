using CourseApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Services
{
    public class UserService : IUserService
    {
        private List<User> users;

        public UserService()
        {
            users = new List<User>()
            {
                new(){Id=1,Name="Ferhat",UserName="ft3065",Password="123",Email="ft@xabc.com",Role="Admin"},
                new(){Id=2,Name="Turgut",UserName="tr3065",Password="123",Email="tr@xabc.com",Role="Editor"},
                new(){Id=3,Name="Ahmet",UserName="aa3065",Password="123",Email="aa@xabc.com",Role="Client"},
            };
        }

        public User? validateUser(string userName, string password)
        {
            return users.SingleOrDefault(u=>u.UserName==userName&&u.Password==password);
        }
    }
}
