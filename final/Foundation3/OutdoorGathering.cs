public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weather) 
            : base(title, description, date, time, address)
        {
            _weatherForecast = weather;
        }

        public string GetFullDetails()
        {
            return $"{GetStandardDetails()}\nType: Outdoor Gathering\nWeather: {_weatherForecast}";
        }

        public string GetOutdoorShortDescription()
        {
             return GetShortDescription("Outdoor Gathering");
        }
    }