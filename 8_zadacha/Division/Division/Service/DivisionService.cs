using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Division.Controler;
using Division.Model;

namespace Division.Service;

internal class DivisionService
{
    private double div1;
    private double div2;
    private double div3;
    public void Cal(DivisionModel model)
    {
        for (int i = 0; i < model.N; i++)
        {
            if (model.Numbers[i] % 2 == 0)
            {
                div1++;
            }
            if(model.Numbers[i] % 3 == 0)
            {
                div2++;
            }
            if(model.Numbers[i] % 4 == 0)
            {
                div3++;
            }
        }
    }
    public void CalPrc(DivisionModel model)
    {
        model.P1 = div1/10 * 100;
        model.P2 = div2/10 * 100;
        model.P3 = div3/10 * 100;
    }
}
