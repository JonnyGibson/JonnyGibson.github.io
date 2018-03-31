namespace FlightFinder.Shared
{
    public class FilterLookupItem
    {
        public string Code { get; set; }
        public string DisplayName { get; set; }

        public FilterLookupItem()
        {

        }
        public FilterLookupItem(string code, string displayName)
        {
            Code = code;
            DisplayName = displayName;
        }
    }
}
