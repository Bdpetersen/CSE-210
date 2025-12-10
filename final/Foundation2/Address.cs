 public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;

        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        // Returns true if the country is USA
        public bool IsUSA()
        {
            return _country.Trim().ToUpper() == "USA";
        }

        // Returns the full address as a string
        public string GetDisplayText()
        {
            return $"{_street}\n{_city}, {_state}\n{_country}";
        }
    }