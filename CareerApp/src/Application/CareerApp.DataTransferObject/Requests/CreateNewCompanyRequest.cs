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
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Username { get; set; }
        [Required, MaxLength(20)]
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Biography { get; set; }
        public string Address { get; set; }

        public int RoleId { get; set; }

    }
}
