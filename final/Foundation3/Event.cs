public class Event
    {
        private string _eventTitle;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;

        public Event(string title, string description, string date, string time, Address address)
        {
            _eventTitle = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        // Returns message 1: Standard Details
        public string GetStandardDetails()
        {
            return $"{_eventTitle}\n{_description}\nDate: {_date} @ {_time}\nAddress: {_address.GetAddressString()}";
        }

        // Returns message 3: Short Description
        // We make this generic, but derived classes can use it or the caller can use it.
        // However, the prompt asks for "Type of Event" which is specific to the derived class.
        // So this helper returns the parts the base class knows.
        public string GetShortDescription(string eventType)
        {
            return $"{eventType}: {_eventTitle} ({_date})";
        }
        
        // Helper getter for derived classes if needed, though mostly we just call methods.
        public string GetTitle() { return _eventTitle; }
        public string GetDate() { return _date; }
    }