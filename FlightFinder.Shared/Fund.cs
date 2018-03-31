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
        public string Name {
            get { return Company + " " + Name; }
            set { Name = value; }
        }
        public string Description {
            get { return "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam ut arcu quam. Phasellus ante dui, egestas quis porttitor eu, molestie a leo. Fusce lobortis,"; }
            set { Name = value; }
        }
        public string Manager { get; set; }
        public string Company { get; set; }
        public string Sector { get; set; }
        public string FundTYpe { get; set; }
        public string Rating { get; set; }

    }
}
