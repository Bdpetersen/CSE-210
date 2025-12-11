 public class Swimming : Activity
    {
        private int _laps;

        public Swimming(string date, int length, int laps) : base(date, length)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            // Distance (miles) = swimming laps * 50 / 1000 * 0.62
            return _laps * 50.0 / 1000.0 * 0.62;
        }

        public override double GetSpeed()
        {
            // Speed = (distance / minutes) * 60
            return (GetDistance() / GetLength()) * 60;
        }

        public override double GetPace()
        {
            // Pace = minutes / distance
            return GetLength() / GetDistance();
        }
    }