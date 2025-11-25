namespace Transport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new Service.Service();
            var controller = new Controler.Controler(service);
            var view = new View.View(controller);
            view.GetValues();
        }
    }
}
