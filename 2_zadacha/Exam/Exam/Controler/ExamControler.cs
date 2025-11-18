using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Service;
using Exam.View;

namespace Exam.Controler
{
    internal class ExamControler
    {
        private readonly ExamService _service;

        public ExamControler(ExamService service)
        {
            _service = service;
        }

        public int ExamServiceCal(Model.ExamModel model)
        {
            return _service.ServiceCal(model);
        }
    }
}
