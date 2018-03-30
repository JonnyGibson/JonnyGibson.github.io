using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FiltersController : Controller
    {
        public  Dictionary<int, string> Get(FilterType filterType)
        {
            switch (filterType)
            {
                case FilterType.Company:
                    return SampleData.Companies;
                    break;
                case FilterType.Sector:
                    return SampleData.Sectors;
                    break;
                case FilterType.Rating:
                    return SampleData.Ratings;
                    break;
                case FilterType.Type:
                    return SampleData.FundTypes;
                    break;
                default:
                    return new Dictionary<int, string>();
                    break;
            };
        }
    }
}
