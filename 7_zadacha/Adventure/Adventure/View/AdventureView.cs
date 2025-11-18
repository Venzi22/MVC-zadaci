using Adventure.Controler;
using Adventure.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.View;

internal class AdventureView
{
    int buget;
    string sezon;
    string place;

    private AdventureConroler _conroler;
    public AdventureView(AdventureConroler conroler)
    {
        _conroler = conroler;
    }

    public void View()
    {
        buget = int.Parse(Console.ReadLine());
        sezon = Console.ReadLine();
        var model = new AdventureModel(buget, sezon, place);
        _conroler.AdveturePickDestination(model);
        Console.WriteLine("Somewhere in " + model.Place);
        Console.WriteLine(model.Budget);
    }
}
