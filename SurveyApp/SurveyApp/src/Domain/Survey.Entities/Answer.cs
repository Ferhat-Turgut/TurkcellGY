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
    public class Answer : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int SurveyId { get; set; } // Ankete referans
        public TheSurvey Survey { get; set; } // Anket ile ilişki
        public int QuestionId { get; set; } // Soruya referans
        public Question Question { get; set; } // Soru ile ilişki

        [Required]
        public string Response { get; set; } // Cevap metni veya değeri
    }
}
