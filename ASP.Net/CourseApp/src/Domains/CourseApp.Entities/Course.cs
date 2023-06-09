﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.Entities
{
    public class Course:IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? Price { get; set; }
        public int? TotalHours { get; set; }
        public string ImageUrl { get; set; }= "https://loremflickr.com/320/240";
        public byte? Rating { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
