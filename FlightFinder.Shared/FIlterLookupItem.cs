namespace FlightFinder.Shared
{
    public class FilterLookupItem
    {
        public int Code { get; set; }
        public string DisplayName { get; set; }

        public FilterLookupItem(int code, string displayName)
        {
            Code = code;
            DisplayName = displayName;
        }
    }
}
