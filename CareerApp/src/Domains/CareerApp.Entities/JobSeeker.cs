using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities
{
    public class JobSeeker
    {
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Surname { get; set; }
        [Required,MaxLength(20)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir email adresi girin.")]
        public string? Email { get; set; }
        [Phone(ErrorMessage = "Lütfen geçerli bir telefon numarası girin.")]
        public string? PhoneNumber { get; set; }

        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int? JobId { get; set; }
        public Job? Job { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public IEnumerable<Recourse>? MyProperty { get; set; }
    }
}
