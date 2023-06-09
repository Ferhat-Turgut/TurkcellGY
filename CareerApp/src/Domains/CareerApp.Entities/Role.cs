using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities
{
    public class Role : IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public IEnumerable<Company>? Companies { get; set; }
        public IEnumerable<JobSeeker>? jobSeekers { get; set; }
    }
}
