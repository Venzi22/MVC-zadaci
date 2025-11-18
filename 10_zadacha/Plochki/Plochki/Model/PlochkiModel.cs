using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.Model;

internal class PlochkiModel
{
    private double nOfPlace;
    public double NOfPlace
    {
        get { return nOfPlace; }
        set { nOfPlace = value; }
    }

    private double wOfPlockata;
    public double WOfPlockata
    {
        get { return wOfPlockata; }
        set { wOfPlockata = value; }
    }

    private double lOfPlockata;
    public double LOfPlockata
    {
        get { return lOfPlockata; }
        set { lOfPlockata = value; }
    }

    private double mOfBench;
    public double MOfBench
    {
        get { return mOfBench; }
        set { mOfBench = value; }
    }

    private double oOfBench;
    public double OOfBench
    {
        get { return oOfBench; }
        set { oOfBench = value; }
    }

    private double timeNeeded;
    public double TimeNeeded
    {
        get { return timeNeeded; }
        set { timeNeeded = value; }
    }

    private double plochkiNeeded;
    public double PlochkiNeeded
    {
        get { return plochkiNeeded; }
        set { plochkiNeeded = value; }
    }

    public PlochkiModel(double n, double wOfP,double lOfP, double mOfBech, double oOfBench, double timeNeeded, double plochkiNeeded)
    {
        NOfPlace = n;
        WOfPlockata = wOfP;
        LOfPlockata = lOfP;
        MOfBench = mOfBech;
        OOfBench = oOfBench;
        TimeNeeded = timeNeeded;
        PlochkiNeeded= plochkiNeeded;
    }
}
