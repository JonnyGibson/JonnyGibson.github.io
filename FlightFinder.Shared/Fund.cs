using System;
using System.Collections.Generic;
using System.Text;

namespace FlightFinder.Shared
{
    public class Fund
    {
        public Fund()
        {

        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Manager { get; set; }
        public string Company { get; set; }
        public string Sector { get; set; }
        public string FundType { get; set; }
        public string Rating { get; set; }

    }
}
