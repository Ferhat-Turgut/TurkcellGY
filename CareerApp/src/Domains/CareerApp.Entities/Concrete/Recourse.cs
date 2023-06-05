using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities.Concrete
{
    public class Recourse
    {
        [Key]
        public int Id { get; set; }
        public DateTime RecourseDate { get; set; }

        public int? JobPostingId { get; set; }
        public JobPosting? JobPosting { get; set; }
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        public int? JobSeekerId { get; set; }
        public JobSeeker? JobSeeker { get; set; }
    }
}
