using Plochki.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.Service;

internal class PlochkiService
{
    private double face;
    private double bench;
    private double plochka;
    public void Cal(PlochkiModel model)
    {
        face = model.NOfPlace * model.NOfPlace;
        bench = model.MOfBench * model.OOfBench;
        plochka = model.WOfPlockata * model.LOfPlockata;

        face = face - bench;
        model.PlochkiNeeded = face/plochka;
        model.TimeNeeded = model.PlochkiNeeded * 0.2;
    }
}
