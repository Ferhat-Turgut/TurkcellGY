using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities.Concrete
{
    public class JobPosting
    {
        [Key]
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string Address { get; set; }
        public string? Description { get; set; }
        public string? Terms { get; set; }
        public bool Status { get; set; }
        public DateTime ListingDate { get; set; }

        public int JobId { get; set; }
        public Job Job { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public IEnumerable<Recourse> Recourses { get; set; }
    }
}
