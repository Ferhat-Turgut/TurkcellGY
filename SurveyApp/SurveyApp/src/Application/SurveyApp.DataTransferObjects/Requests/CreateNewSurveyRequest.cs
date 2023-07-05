using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Survey.Entities;

namespace SurveyApp.DataTransferObjects.Requests
{
    public class CreateNewSurveyRequest
    {
        
        [Required(ErrorMessage = "Anket başlığı boş geçilemez")]
        public string Tittle { get; set; }
        public List<CreateNewQuestionRequest> Questions { get; set; }
    }
}
