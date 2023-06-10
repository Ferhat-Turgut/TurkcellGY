using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Requests
{
    public class CreateNewJobSeekerRequest
    {
     
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Surname { get; set; }
        [Required, MaxLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public int? Age { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }

        public int? CityId { get; set; }
        public City City { get; set; }
        public int? JobId { get; set; }
        public Job Job { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
