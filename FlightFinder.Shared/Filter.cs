namespace FlightFinder.Shared
{
    public class Filter
    {
        public string Code { get; set; }
        public string DisplayName { get; set; }

        public Filter(string code, string displayName)
        {
            Code = code;
            DisplayName = displayName;
        }
    }
}
