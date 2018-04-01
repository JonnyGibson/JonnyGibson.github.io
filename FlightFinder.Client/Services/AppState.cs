using FlightFinder.Shared;
using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;

namespace FlightFinder.Client.Services
{
    public class AppState
    {
        // Actual state
        public IReadOnlyList<Itinerary> SearchResults { get; private set; }
        public bool SearchInProgress { get; private set; }
        public FilterType FilterTypeSelected { get;  set; }
        public string FilterItemSelected { get; set; }
         
        public List<Fund> FundList = new List<Fund>();

        public List<Fund> Basket = new List<Fund>();

        private readonly List<Itinerary> shortlist = new List<Itinerary>();
        public IReadOnlyList<Itinerary> Shortlist => shortlist;

        public List<string> LogItems = new List<string>();
        public void Log(string item) => LogItems.Add(item);
        // Lets components receive change notifications
        // Could have whatever granularity you want (more events, hierarchy...)
        public event Action OnChange;

        // Receive 'http' instance from DI
        private readonly HttpClient http;
        public AppState(HttpClient httpInstance)
        {
            http = httpInstance;
        }

        public async Task Search(SearchCriteria criteria)
        {
            SearchInProgress = true;
            NotifyStateChanged();

            SearchResults = await http.PostJsonAsync<Itinerary[]>("/api/flightsearch", criteria);
            SearchInProgress = false;
            NotifyStateChanged();
        }

        public async Task Add(string filterItem)
        {
             AddFilter(FilterTypeSelected, filterItem);
        }
        public async Task RemoveFilterItem(FilterType filterType)
        {
            SelectedFilters.Remove(filterType);

        }

        public async Task GetFundList()
        {
            SearchInProgress = true;
            NotifyStateChanged();
            Log("GetFundList");

            var filterString = "";
            var values = Enum.GetValues(typeof(FilterType));
            foreach (var item in values)
            {
                if (SelectedFilters.ContainsKey((FilterType)item))
                {
                    foreach (var value in SelectedFilters[(FilterType)item])
                    {
                        filterString += $"{((FilterType)item).ToDisplayString()}={value} &";
                    }
                }
            }
            var list =  await http.GetJsonAsync<Fund[]>($"/api/funds/funds?{filterString}");
            FundList = list.ToList();
            SearchInProgress = false;
            NotifyStateChanged();
        }

        public void AddToShortlist(Itinerary itinerary)
        {
            shortlist.Add(itinerary);
            NotifyStateChanged();
        }

        public void RemoveFromShortlist(Itinerary itinerary)
        {
            shortlist.Remove(itinerary);
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();

        public Dictionary<FilterType, List<string>> SelectedFilters = new Dictionary<FilterType, List<string>>();

        public void AddFilter(FilterType filterType, string filter)
        {
            Log($"adding value:{filter} to {filterType.ToDisplayString()}");
          
            if (SelectedFilters.ContainsKey(filterType))
            {
                var currentTypeFilters = SelectedFilters[filterType];
                if (!currentTypeFilters.Contains(filter)){
                    currentTypeFilters.Add(filter);
                    SelectedFilters[filterType] = currentTypeFilters;
                }
            }
            else
            {
                SelectedFilters.Add(filterType, new List<string> { filter });
            }
            
        }
    }
}
