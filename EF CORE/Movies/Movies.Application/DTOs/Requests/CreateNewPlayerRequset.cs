using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.Application.DTOs.Requests
{
    public class CreateNewPlayerRequset
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Info { get; set; }
    }
}
