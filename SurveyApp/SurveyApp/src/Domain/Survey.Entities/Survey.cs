using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Entities
{
    public class TheSurvey : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Tittle { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        [Required]
        public List<Question> Questions { get; set; }
        public List<Answer>? Answers { get; set; } // Anketteki cevaplar
    }
}
