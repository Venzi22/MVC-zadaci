using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Division.View;
using Division.Service;
using Division.Model;
using System.Xml.Serialization;

namespace Division.Controler;

internal class DivisionControler
{
    private DivisionService _service;
    public DivisionControler(DivisionService service)
    {
        _service = service;
    }

    public void Cal(DivisionModel model)
    {
        _service.Cal(model);
    }
    public void CalPrc(DivisionModel model)
    {
        _service.CalPrc(model);
    }
}
