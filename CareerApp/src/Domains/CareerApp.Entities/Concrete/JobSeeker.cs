using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities.Concrete
{
    public class JobSeeker
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }

        public int? JobId { get; set; }
        public Job? Job { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }

        public IEnumerable<Recourse>? Recourses { get; set; }
    }
}
