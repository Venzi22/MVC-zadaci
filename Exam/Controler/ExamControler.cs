using Exam.Service;
namespace Exam.Controler;

public class ExamControler
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
