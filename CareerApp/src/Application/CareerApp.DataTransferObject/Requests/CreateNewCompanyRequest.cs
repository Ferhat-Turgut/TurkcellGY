using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Requests
{
    public class CreateNewCompanyRequest
    {
        [Required, MaxLength(50)]
        public string name { get; set; }
        [Required, MaxLength(20)]
        public string username { get; set; }
        [Required, MaxLength(20)]
        public string password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Biography { get; set; }
        public string address { get; set; }

        public int? roleId { get; set; }

    }
}
