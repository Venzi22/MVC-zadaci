using Plochki.Controler;
using Plochki.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.View;

internal class PlochkiView
{
    public double n;
    public double wOfPlochka;
    public double lOfPlochka;
    public double mOfBench;
    public double oOfBench;
    public double plochki;
    public double timeNeeded;

    private PlochkiControler _controler;

    public PlochkiView( PlochkiControler controler )
    {
        _controler = controler;
    }

    public void View()
    {
        n = double.Parse(Console.ReadLine());
        wOfPlochka = double.Parse(Console.ReadLine());
        lOfPlochka = double.Parse(Console.ReadLine());
        mOfBench = double.Parse(Console.ReadLine());
        oOfBench = double.Parse(Console.ReadLine());

        var model = new PlochkiModel(n,wOfPlochka,lOfPlochka,mOfBench,oOfBench,timeNeeded,plochki);
        _controler.Cal(model);

        Console.WriteLine(model.PlochkiNeeded);
        Console.WriteLine(model.TimeNeeded);
    }
}
