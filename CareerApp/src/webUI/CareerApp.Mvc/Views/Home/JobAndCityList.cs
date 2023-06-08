using CareerApp.Entities;

namespace CareerApp.Mvc.Views.Home
{
    public class JobAndCityList
    {
        public IEnumerable<Job> Jobs { get; set; }
        public IEnumerable<City> Cities { get; set; }
    }
}
