using System;
namespace Transport.Service
{
    internal class Service
    {
        public double Taxi(Model.Model model)
        {
            if (model.TimeOfDay.ToLower() == "day")
            {
                model.Price = 0.70 + model.Km * 0.79;
                return model.Price;
            }
            else if (model.TimeOfDay.ToLower() == "night")
            {
                model.Price = 0.70 + model.Km * 0.90;
                return model.Price;
            }
            else
            {
                Console.WriteLine("Error, please try again and enter day/night");
            }
            return model.Price;
        }
        public double Bus(Model.Model model)
        {
            model.Price = model.Km * 0.09;
            return model.Price;
        }
        public double Train(Model.Model model)
        {
            model.Price = model.Km * 0.06;
            return model.Price;
        }
    }
}
