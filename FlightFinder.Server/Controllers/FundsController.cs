using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FlightFinder.Server.Controllers
{
    [Route("api/[controller]")]
    public class FundsController : Controller
    {
        [Route("funds")]
        public IEnumerable<Fund> Funds(
                string[] company, string[] sector,
                string[] type, string[] rating)
        {

            return SampleData.Funds.Take(2); 

        }
    }
}
