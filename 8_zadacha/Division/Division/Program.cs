using Division.Controler;
using Division.Service;
using Division.View;

namespace Division
{
    internal class Program
    {
        static void Main()
        {
            DivisionService service = new DivisionService();
            DivisionControler controler = new DivisionControler(service);
            DivisionView view = new DivisionView(controler);
            view.View();
        }
    }
}
