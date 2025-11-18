using MagicNumbers.Controler;
using MagicNumbers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.View;

internal class MagicNumbersView
{
    public int magicNumber;
    public List<int> magicDigits = new List<int>();

    private MagicNumbersControler _controler;

    public MagicNumbersView(MagicNumbersControler controler)
    {
        _controler = controler;
    }

    public void View()
    {
        magicNumber = int.Parse(Console.ReadLine());
        var model = new MagicNumbersModel(magicNumber,magicDigits);
        _controler.GetResults(model);

        foreach (var item in model.MagicDigits)
        {
            Console.WriteLine(item);
        }

    }
}
