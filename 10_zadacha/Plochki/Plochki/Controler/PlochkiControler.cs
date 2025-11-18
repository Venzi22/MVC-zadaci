using Plochki.Model;
using Plochki.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plochki.Controler;

internal class PlochkiControler
{
    private PlochkiService _service;
    public PlochkiControler(PlochkiService service)
    {
        _service = service;
    }

    public void Cal(PlochkiModel model)
    {
        _service.Cal(model);
    }
}
