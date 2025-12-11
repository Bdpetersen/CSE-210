public class Activity
    {
        // Shared attributes
        private string _date;
        private int _length; // in minutes

        public Activity(string date, int length)
        {
            _date = date;
            _length = length;
        }

        // Standard getter for length to be used by derived classes for calculations
        public int GetLength()
        {
            return _length;
        }

        // Virtual methods meant to be overridden
        // We return 0 by default so the code compiles, but children will replace this logic
        public virtual double GetDistance()
        {
            return 0;
        }

        public virtual double GetSpeed()
        {
            return 0;
        }

        public virtual double GetPace()
        {
            return 0;
        }

        // The Summary method is defined once here and uses the overridden methods
        public string GetSummary()
        {
            // We use GetType().Name to automatically get "Running", "Cycling", etc.
            string type = this.GetType().Name;
            
            return $"{_date} {type} ({_length} min) - Distance {GetDistance():0.0} miles, Speed {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
    }
