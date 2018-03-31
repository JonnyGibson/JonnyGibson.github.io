namespace FlightFinder.Shared
{
    public class FilterLookupItem
    {
        public string Code { get; set; }
        public string DisplayName { get; set; }

        public FilterLookupItem()
        {

        }
        public FilterLookupItem(int code, string displayName)
        {
            Code = code.ToString();
            DisplayName = displayName;
        }
    }
}
