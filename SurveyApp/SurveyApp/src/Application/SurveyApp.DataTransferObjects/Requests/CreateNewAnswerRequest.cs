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

    public class CreateNewAnswerRequest
    {
        public Dictionary<int, string> Responses { get; set; } = new Dictionary<int, string>();
    }


}
