using FlightFinder.Shared;
using System.Collections.Generic;
using System;

namespace FlightFinder.Server
{
    public class SampleData
    {





        public readonly static Dictionary<int, string> Companies =
            new Dictionary<int, string>(){
            {1001,"Invesco International" },
             {1002,"Prudential Money Peope" },
              {1003,"Hargreaves Lansdown AM" },
               {1004,"Vanguard Forefront Group" },
                {1005,"Big Daddy Bank" },
                 {1006,"Natwest Investment Providers" }
        };
        public readonly static Dictionary<int, string> Sectors =
            new Dictionary<int, string>(){
            {2001,"Europe" },
             {2002,"UK" },
              {2003,"Asia Middle East" },
               {2004,"Emerging Markets" },
                {2005,"Property" }
        };

        public readonly static Dictionary<int, string> Ratings =
           new Dictionary<int, string>(){
            {3001,"1 Star" },
             {3002,"2 Star" },
              {3003,"3 Star" },
               {3004,"4 Star" },
                {3005,"5 Star" }
       };


        public readonly static Dictionary<int, string> FundTypes =
           new Dictionary<int, string>(){
            {4001,"Fixed Income" },
             {4002,"Balanced Funds" },
              {4003,"Speciality" },
               {4004,"Fund of funds" },
                {4005,"Equity Funds" }
       };

        public readonly static Airport[] Airports = new[]
        {
            new Airport { Code = "ATL", DisplayName = "Hartsfield–Jackson Atlanta International" },
            new Airport { Code = "PEK", DisplayName = "Beijing Capital International" },
            new Airport { Code = "DXB", DisplayName = "Dubai International" },
            new Airport { Code = "LAX", DisplayName = "Los Angeles International" },
            new Airport { Code = "HND", DisplayName = "Tokyo Haneda International" },
            new Airport { Code = "ORD", DisplayName = "O'Hare International" },
            new Airport { Code = "LHR", DisplayName = "London Heathrow" },
            new Airport { Code = "HKG", DisplayName = "Hong Kong International" },
            new Airport { Code = "PVG", DisplayName = "Shanghai Pudong International" },
            new Airport { Code = "CDG", DisplayName = "Charles de Gaulle" },
            new Airport { Code = "DFW", DisplayName = "Dallas/Fort Worth International" },
            new Airport { Code = "AMS", DisplayName = "Amsterdam Schiphol" },
            new Airport { Code = "FRA", DisplayName = "Frankfurt" },
            new Airport { Code = "IST", DisplayName = "Istanbul Atatürk" },
            new Airport { Code = "CAN", DisplayName = "Guangzhou Baiyun International" },
            new Airport { Code = "JFK", DisplayName = "John F. Kennedy International" },
            new Airport { Code = "SIN", DisplayName = "Singapore Changi" },
            new Airport { Code = "DEN", DisplayName = "Denver International" },
            new Airport { Code = "ICN", DisplayName = "Seoul Incheon International" },
            new Airport { Code = "BKK", DisplayName = "Suvarnabhumi" },
            new Airport { Code = "DEL", DisplayName = "Indira Gandhi International" },
            new Airport { Code = "CGK", DisplayName = "Soekarno–Hatta International" },
            new Airport { Code = "SFO", DisplayName = "San Francisco International" },
            new Airport { Code = "KUL", DisplayName = "Kuala Lumpur International" },
            new Airport { Code = "MAD", DisplayName = "Madrid Barajas" },
            new Airport { Code = "LAS", DisplayName = "McCarran International" },
            new Airport { Code = "CTU", DisplayName = "Chengdu Shuangliu International" },
            new Airport { Code = "SEA", DisplayName = "Seattle-Tacoma International" },
            new Airport { Code = "BOM", DisplayName = "Chhatrapati Shivaji International" },
            new Airport { Code = "MIA", DisplayName = "Miami International" },
            new Airport { Code = "CLT", DisplayName = "Charlotte Douglas International" },
            new Airport { Code = "YYZ", DisplayName = "Toronto Pearson International" },
            new Airport { Code = "BCN", DisplayName = "Barcelona–El Prat" },
            new Airport { Code = "PHX", DisplayName = "Phoenix Sky Harbor International" },
            new Airport { Code = "LGW", DisplayName = "London Gatwick" },
            new Airport { Code = "TPE", DisplayName = "Taiwan Taoyuan International" },
            new Airport { Code = "MUC", DisplayName = "Munich" },
            new Airport { Code = "SYD", DisplayName = "Sydney Kingsford-Smith" },
            new Airport { Code = "KMG", DisplayName = "Kunming Changshui International" },
            new Airport { Code = "SZX", DisplayName = "Shenzhen Bao'an International" },
            new Airport { Code = "MCO", DisplayName = "Orlando International" },
            new Airport { Code = "FCO", DisplayName = "Leonardo da Vinci–Fiumicino" },
            new Airport { Code = "IAH", DisplayName = "George Bush Intercontinental" },
            new Airport { Code = "MEX", DisplayName = "Benito Juárez International" },
            new Airport { Code = "SHA", DisplayName = "Shanghai Hongqiao International" },
            new Airport { Code = "EWR", DisplayName = "Newark Liberty International" },
            new Airport { Code = "MNL", DisplayName = "Ninoy Aquino International" },
            new Airport { Code = "NRT", DisplayName = "Narita International" },
            new Airport { Code = "MSP", DisplayName = "Minneapolis/St Paul International" },
            new Airport { Code = "DOH", DisplayName = "Hamad International" },
        };

        public readonly static string[] Airlines = new[]
        {
            "American Airlines",
            "British Airways",
            "Delta",
            "Emirates",
            "Etihad",
            "JetBlue",
            "KLM",
            "Singapore Airways",
            "Qantas",
            "Virgin Atlantic",
        };

        public readonly static Fund[] Funds = new Fund[]
        {
            new Fund {Id = Guid.NewGuid(), Company = "Invesco Perpetual", Name = "Super Fund 99", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Invesco Perpetual", Name = "Super Fund 88", Description = "A Desc", FundTYpe = "Fund of Funds", Manager = "John Smith", Rating = "4 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Invesco Perpetual", Name = "Super Fund 43", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "3 Star", Sector = "UK" },
            new Fund {Id = Guid.NewGuid(), Company = "Invesco Perpetual", Name = "Naff Thing", Description = "A Desc", FundTYpe = "Unit Trust", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Invesco Perpetual", Name = "Spread Bet", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "5 Star", Sector = "Emerging Markets" },

                        new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Super Fund 99", Description = "A Desc", FundTYpe = "Fund of Funds", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Super Fund 88", Description = "A Desc", FundTYpe = "Equities", Manager = "John Smith", Rating = "4 Star", Sector = "UK" },
            new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Super Fund 43", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "3 Star", Sector = "Asia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Naff Thing", Description = "A Desc", FundTYpe = "Unit Trust", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Spread Bet", Description = "A Desc", FundTYpe = "Bonds", Manager = "John Smith", Rating = "5 Star", Sector = "Emerging Markets" },

                                    new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Super Fund 99", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Vanguard Investments", Name = "Super Fund 88", Description = "A Desc", FundTYpe = "Equities", Manager = "John Smith", Rating = "4 Star", Sector = "ASia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Vanguard Investments", Name = "Super Fund 43", Description = "A Desc", FundTYpe = "Fund of Funds", Manager = "John Smith", Rating = "3 Star", Sector = "Asia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Vanguard Investments", Name = "Naff Thing", Description = "A Desc", FundTYpe = "Unit Trust", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Vanguard Investments", Name = "Spread Bet", Description = "A Desc", FundTYpe = "Bonds", Manager = "John Smith", Rating = "5 Star", Sector = "Emerging Markets" },

                                                new Fund {Id = Guid.NewGuid(), Company = "Natwest Investments", Name = "Super Fund 99", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Hargreaves Lansdown AM", Name = "Super Fund 88", Description = "A Desc", FundTYpe = "Equities", Manager = "John Smith", Rating = "4 Star", Sector = "ASia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Hargreaves Lansdown AM", Name = "Super Fund 43", Description = "A Desc", FundTYpe = "Fund of Funds", Manager = "John Smith", Rating = "3 Star", Sector = "Asia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Hargreaves Lansdown AM", Name = "Naff Thing", Description = "A Desc", FundTYpe = "Unit Trust", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Hargreaves Lansdown AM", Name = "Spread Bet", Description = "A Desc", FundTYpe = "Bonds", Manager = "John Smith", Rating = "5 Star", Sector = "Emerging Markets" },

                                 new Fund {Id = Guid.NewGuid(), Company = "Prudential Fancy Bank", Name = "Super Fund 99", Description = "A Desc", FundTYpe = "ETF", Manager = "John Smith", Rating = "5 Star", Sector = "EU" },
            new Fund {Id = Guid.NewGuid(), Company = "Prudential Fancy Bank", Name = "Super Fund 88", Description = "A Desc", FundTYpe = "Equities", Manager = "John Smith", Rating = "4 Star", Sector = "ASia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Prudential Fancy Bank", Name = "Super Fund 43", Description = "A Desc", FundTYpe = "Fund of Funds", Manager = "John Smith", Rating = "3 Star", Sector = "Asia & Middle East" },
            new Fund {Id = Guid.NewGuid(), Company = "Prudential Fancy Bank", Name = "Naff Thing", Description = "A Desc", FundTYpe = "Unit Trust", Manager = "John Smith", Rating = "5 Star", Sector = "UK" },
            new Fund {Id = Guid.NewGuid(), Company = "Prudential Fancy Bank", Name = "Spread Bet", Description = "A Desc", FundTYpe = "Bonds", Manager = "John Smith", Rating = "5 Star", Sector = "Emerging Markets" }

        };
    }
}

