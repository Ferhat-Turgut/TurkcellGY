using SurveyApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}
