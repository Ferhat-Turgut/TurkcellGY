using AutoMapper;
using Survey.Entities;
using SurveyApp.DataTransferObjects.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurveyApp.Services.Extensions
{
    public static class MappingExtensions
    {
        public static IEnumerable<TheSurveyDisplayResponse> ConvertToDisplayResponses(this IEnumerable<TheSurvey> surveys, IMapper mapper)
        {
            return mapper.Map<IEnumerable<TheSurveyDisplayResponse>>(surveys);
        }
      

    }
}
