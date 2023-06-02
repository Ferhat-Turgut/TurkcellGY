using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObjects.Responses
{
    public class JobPostingDisplayResponse
    {
        public string Tittle { get; set; }
        public string? Description { get; set; }
        public string? Terms { get; set; }
        [Required]
        public bool Status { get; set; } = true;
        [Required]
        public DateTime ListingDate { get; set; }
        //public int CompanyId { get; set; }
        //public Company Company { get; set; }
        //public int JobId { get; set; }
        //public Job Job { get; set; }
    }
}
