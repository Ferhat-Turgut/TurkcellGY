using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities
{
    public class Company
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Address { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi girin.")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Lütfen geçerli bir telefon numarası girin.")]
        public string? PhoneNumber { get; set; }
        public string? Biography { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }

        public IEnumerable<JobPosting>? JobPostings { get; set; }
    }
}
