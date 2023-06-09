﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerApp.Entities
{
    public class Job:IEntity
    {
        [Key]
        public int Id { get; set; }
        [Required,MaxLength(30)]
        public string Name { get; set; }
        public IEnumerable<JobPosting>? jobPostings { get; set; }
    }
}
