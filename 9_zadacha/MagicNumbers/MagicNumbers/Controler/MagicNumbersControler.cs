using MagicNumbers.Model;
using MagicNumbers.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers.Controler;

internal class MagicNumbersControler
{
    private MagicNumbersService _service;

    public MagicNumbersControler(MagicNumbersService service)
    {
        _service = service;
    }

    public void GetResults(MagicNumbersModel model)
    {
        _service.Magic(model);
    }
}
