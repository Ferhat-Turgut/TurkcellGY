using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Responses
{
    public class RecourseDisplayResponse
    {
    
        public int Id { get; set; }
        public DateTime RecourseDate { get; set; }
        public Company? Company { get; set; }
        public JobPosting? JobPosting { get; set; }
    }
}
