using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Responses
{
    public class JobPostingDisplayResponse
    {
       
        public int Id { get; set; }
        public string Tittle { get; set; }
        public DateTime ListingDate { get; set; }

        public City City { get; set; }
        public Company Company { get; set; }
        public Job Job { get; set; }

    }
}
