using Exam.Controler;
using Exam.Service;
using Exam.View;
namespace Exam;

public class Program
{
    static void Main()
    {

        ExamService service = new ExamService();
        ExamControler controler = new ExamControler(service);
        ExamView view = new ExamView(controler);
        view.View();
    }
}
