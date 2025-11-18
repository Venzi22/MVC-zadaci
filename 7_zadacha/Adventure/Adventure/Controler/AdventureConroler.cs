using Adventure.NewFolder;
using Adventure.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure.Controler;

internal class AdventureConroler
{
    private AdventureService _service;

    public AdventureConroler(AdventureService service)
    {
        _service = service;
    }

    public void AdveturePickDestination(AdventureModel model) 
    {
        if (model.Budget <= 100)
        {
            _service.PickBulgaria(model);
        }
        if (model.Budget > 100 && model.Budget <= 1000)
        {
            _service.PickBalkan(model);
        }
        else
        {
            _service.PickEurope(model);
        }
    }
}
