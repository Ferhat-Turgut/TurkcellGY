using CareerApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.DataTransferObject.Requests
{
    public class CreateNewJobPostingRequest
    {
       
        [Required(ErrorMessage ="İlan Başlığı boş geçilemez!")]
        [ MaxLength(50)]
        public string Tittle { get; set; }
        public string? Description { get; set; }
        public string? Terms { get; set; }
        [Required]
        public bool Status { get; set; } = true;
        [Required]
        public DateTime ListingDate { get; set; }

        [Required(ErrorMessage = "Şehir  boş geçilemez!")]
        public int CityId { get; set; }
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Meslek adı boş geçilemez!")]
        public int JobId { get; set; }

    }
}
