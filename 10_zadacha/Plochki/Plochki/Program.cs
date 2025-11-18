using Plochki.Controler;
using Plochki.Service;
using Plochki.View;

namespace Plochki;

internal class Program
{
    static void Main()
    {
        PlochkiService service = new PlochkiService();
        PlochkiControler controler = new PlochkiControler(service);
        PlochkiView view = new PlochkiView(controler);
        view.View();
    }
}
