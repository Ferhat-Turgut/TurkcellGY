﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.DTOs.Requests
{
    public class CreateNewMovieRequest
    {
        public string Name { get; set; }
        public DateTime? PublishDate { get; set; }
        public string? Poster { get; set; }
        public int? Duration { get; set; }
        public double? Rating { get; set; }

        public int? DirectorId { get; set; }

    }
}
