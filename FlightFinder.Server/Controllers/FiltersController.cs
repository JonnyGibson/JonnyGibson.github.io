using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FiltersController : Controller
    {
        [Route("filters")]
        public  IEnumerable<FilterLookupItem> Filters(FilterType filterType)
        {

            switch (filterType)
            {
                case FilterType.Company:
                    return SampleData.Funds.Select(f => f.Company).Distinct().Select(x => new FilterLookupItem(x, x));
                    break;
                case FilterType.Sector:
                    return SampleData.Funds.Select(f => f.Sector).Distinct().Select(x => new FilterLookupItem(x, x));
                    break;
                case FilterType.Rating:
                    return SampleData.Funds.Select(f => f.Rating).Distinct().Select(x => new FilterLookupItem(x, x));
                    break;
                case FilterType.Type:
                    return SampleData.Funds.Select(f => f.FundType).Distinct().Select(x => new FilterLookupItem(x, x));
                    break;
                default:
                    return null;
                    break;
            };
        }
    }
}
