﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.DTOs.Responses
{
    public class SinglePlayerResponse
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Info { get; set; }
    }
}
