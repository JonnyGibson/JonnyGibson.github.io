using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class AirportsController : Controller
    {
        public IEnumerable<Airport> Airports()
        {
            return SampleData.Airports;
        }

        [Route("filters")]
        public IEnumerable<FilterLookupItem> filters()
        {
            return new List<FilterLookupItem>() {
                new FilterLookupItem(1, "test one"),
                new FilterLookupItem(2, "test two") };

        }
    }
    }
