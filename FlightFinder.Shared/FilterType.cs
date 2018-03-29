using System;

namespace FlightFinder.Shared
{

    public enum FilterType : int
    {
        Company = 0,
        Sector = 1,
        Rating = 2,
        Type = 3,
    }
    public static class FilterTypeClassExtensions
    {
        public static string ToDisplayString(this FilterType filterType)
        {
            switch (filterType)
            {
                case FilterType.Company: return "Company";
                case FilterType.Sector: return "Sector";
                case FilterType.Rating: return "Rating";
                case FilterType.Type: return "Fund Type";
                default: throw new ArgumentException("Unknown ticket class: " + filterType.ToString());
            }
        }
    }
}
