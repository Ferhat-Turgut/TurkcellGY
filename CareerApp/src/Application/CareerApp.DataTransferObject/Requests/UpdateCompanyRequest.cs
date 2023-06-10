using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Requests
{
    public class UpdateCompanyRequest
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Biography { get; set; }
        public string Address { get; set; }

        public int RoleId { get; set; }
        public Role Role { get; set; }
        public IEnumerable<JobPosting>? JobPostings { get; set; }
        public IEnumerable<Recourse>? Recourses { get; set; }
    }
}
