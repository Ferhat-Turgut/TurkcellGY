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
        public string? Address { get; set; }
        public string? Biography { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }

        public IEnumerable<JobPosting>? JobPostings { get; set; }
    }
}
