using FlightFinder.Shared;
using Microsoft.AspNetCore.Blazor;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlightFinder.Client.Services
{
    public class AppState
    {
        // Actual state
        public IReadOnlyList<Itinerary> SearchResults { get; private set; }
        public bool SearchInProgress { get; private set; }
        public FilterType FilterTypeSelected { get;  set; }
        public int FilterIdSelected { get; set; }

        private readonly List<Itinerary> shortlist = new List<Itinerary>();
        public IReadOnlyList<Itinerary> Shortlist => shortlist;

        // Lets components receive change notifications
        // Could have whatever granularity you want (more events, hierarchy...)
        public event Action OnChange;

        // Receive 'http' instance from DI
        private readonly HttpClient http;
        public AppState(HttpClient httpInstance)
        {
            http = httpInstance;
        }

        public async Task<FilterLookupItem[]> GetFilters(FilterType filterType)
        {
            return await http.GetJsonAsync<FilterLookupItem[]>($"/api/filters/filters?filtertype={filterType.ToDisplayString()}");           
        }

        public async Task Search(SearchCriteria criteria)
        {
            SearchInProgress = true;
            NotifyStateChanged();

            SearchResults = await http.PostJsonAsync<Itinerary[]>("/api/flightsearch", criteria);
            SearchInProgress = false;
            NotifyStateChanged();
        }

        public async Task Add(int id)
        {
            SearchInProgress = true;
            NotifyStateChanged();

            SearchResults = await http.PostJsonAsync<Itinerary[]>("/api/flightsearch", id);
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
    }
}
