using Histograma.Controler;
using Histograma.Model;
using Histograma.Service;
using Histograma.View;

namespace Histograma
{
    internal class Program
    {
        static void Main()
        {
            HistogramaService service = new HistogramaService();
            HistogramaControler controler = new HistogramaControler(service);
            HistogramaView view = new HistogramaView(controler);
            view.PrintView();
        }
    }
}
