using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Requests
{
    public class UpdateJobPostingRequest
    {
  
        public string Tittle { get; set; }
        public string? Description { get; set; }
        public string? Terms { get; set; }
        [Required]
        public bool Status { get; set; } = true;
     

        public int CityId { get; set; }
        public City City { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }

    }
}
