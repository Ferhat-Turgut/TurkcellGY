using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Requests
{
    public class CreateNewRecourseRequest
    {
        public DateTime RecourseDate { get; set; }
        public int? CompanyId { get; set; }
        public int? JobSeekerId { get; set; }
        public int? JobPostingId { get; set; }
    }
}
