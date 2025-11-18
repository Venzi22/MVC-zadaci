using MagicNumbers.Controler;
using MagicNumbers.Model;
using MagicNumbers.Service;
using MagicNumbers.View;

namespace MagicNumbers;

internal class Program
{
    static void Main()
    {
        MagicNumbersService service = new MagicNumbersService();
        MagicNumbersControler controler = new MagicNumbersControler(service);
        MagicNumbersView view = new MagicNumbersView(controler);
        view.View();
    }
}
