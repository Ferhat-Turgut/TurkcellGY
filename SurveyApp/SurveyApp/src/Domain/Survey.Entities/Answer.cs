using SurveyApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Survey.Entities
{
    public class Answer : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int QuestionId { get; set; } // Soruya referans
        public Question Question { get; set; } // Soru ile ilişki

        [Required]
        public string Response { get; set; } // Cevap metni veya değeri
    }
}
