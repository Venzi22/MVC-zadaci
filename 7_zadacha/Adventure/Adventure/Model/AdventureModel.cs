using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.NewFolder;

internal class AdventureModel
{
    private int budget;
    public int Budget
    {
        get { return budget; }
        set { budget = value; }
    }
    private string sezon;
    public string Sezon
    {
        get { return sezon; }
        set { sezon = value; }
    }
    private string place;
    public string Place
    {
        get { return place; }
        set { place = value; }
    }

    public AdventureModel(int buget, string sezon, string place)
    {
        Budget = buget;
        Sezon = sezon;
        Place = place;
    }
}
