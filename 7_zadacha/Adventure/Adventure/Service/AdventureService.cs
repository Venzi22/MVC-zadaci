using Adventure.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Service;

internal class AdventureService
{
    private double _budgetPrc;
    public void PickBulgaria(AdventureModel model)
    {
        model.Place = "Bulgaria";
        if (model.Sezon.ToLower() == "summer")
        {
            _budgetPrc = 30 / 100 * model.Budget;
            model.Budget -= _budgetPrc;
        }
        else if(model.Sezon.ToLower() == "winter")
        {
            _budgetPrc = 70 / 100 * model.Budget;
            model.Budget -= _budgetPrc;
        }
        else
        {
            throw new Exception("Invalid season");
        }
    }
    public void PickBalkan(AdventureModel model)
    {
        model.Place = "Balkans";
        if (model.Sezon.ToLower() == "summer")
        {
            _budgetPrc = 40 /100 * model.Budget;
            model.Budget -= _budgetPrc;
        }
        else if (model.Sezon.ToLower() == "winter")
        {
            _budgetPrc = 80 / 100 * model.Budget;
            model.Budget -= _budgetPrc;
        }
        else
        {
            throw new Exception("Invalid season");
        }
    }
    public void PickEurope(AdventureModel model)
    {
        _budgetPrc = 90 / 100 * model.Budget;
        Console.WriteLine($"Somewhere in {model.Place}");
        model.Budget -= _budgetPrc;
        model.Place = "Europe";
    }
}
