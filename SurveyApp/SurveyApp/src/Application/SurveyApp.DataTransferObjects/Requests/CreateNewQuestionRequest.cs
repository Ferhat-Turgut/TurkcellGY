using Survey.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.DataTransferObjects.Requests
{
    public class CreateNewQuestionRequest
    {
       
        [Required(ErrorMessage ="Soru boş geçilemez.")]
        public string QuestionText { get; set; }
        [Required]
        public AnswerType AnswerType { get; set; }
        public List<CreateNewAnswerOptionRequest>? AnswerOptions { get; set; }
    }
}
