using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FiltersController : Controller
    {
        public IEnumerable<Filter> Filters()
        {
            return SampleData.Filters;
        }
    }
}
