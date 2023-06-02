using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities
{
    public class Recourse
    {
        public int Id { get; set; }
        [Required]
        public DateTime RecourseDate { get; set; }

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }

        public int? JobSeekerId { get; set; }
        public JobSeeker? JobSeeker { get; set; }
        public int? JobPostingId { get; set; }
        public JobPosting? JobPosting { get; set; }
    }
}
