using CareerApp.Entities;
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
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string? Description { get; set; }
        public string? Terms { get; set; }
        public bool Status { get; set; } = true;
        public DateTime ListingDate { get; set; }

        public City CityId { get; set; }
        public string City { get; set; }
        public int CompanyId { get; set; }
        public string Company { get; set; }
        public int JobId { get; set; }
        public string Job { get; set; }

    }
}
