using FlightFinder.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
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
            var returnValue = SampleData.Funds.Where(x =>
                                   (!company.Any() || company.Contains(x.Company))
                                     && (!type.Any() || type.Contains(x.FundType))
                                      && (!sector.Any() || sector.Contains(x.Sector))
                                     && (!rating.Any() || rating.Contains(x.Rating))
                               );
            return returnValue;


        }


    }
}

