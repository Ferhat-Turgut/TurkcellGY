﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Survey.Entities
{
    public class Question : IEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string QuestionText { get; set; }
        public int SurveyId { get; set; }
        public TheSurvey Survey { get; set; }
        [Required]
        public AnswerType AnswerType { get; set; }
        public List<AnswerOption>? AnswerOptions { get; set; }
    }
}
