namespace Transport.Model
{
    internal class Model
    {
        private double _km;
        public double Km
        {
            get { return _km; }
            set { _km = value; }
        }

        private string _timeOfDay;
        public string TimeOfDay
        {
            get { return _timeOfDay; }
            set { _timeOfDay = value; }
        }
        private double _price;
        public double Price 
        {
            get { return _price; }
            set { _price = value; }
        }
        public Model(double km, string timeOfDay, double price)
        {
            Km = km;
            TimeOfDay = timeOfDay;
            Price = price;
        }
    }
}
