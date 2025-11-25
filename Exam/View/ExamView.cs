using Exam.Controler;
namespace Exam.View;

public class ExamView
{
    public string Status;
    public int HrOfExam;
    public int MinOfExam;
    public int HrAraived;
    public int MinAraived;
    public int MinLateOREarly;
    public int HrLateOREarly;

    private ExamControler _controler;
    public ExamView(ExamControler controler )
    {
        _controler = controler;
    }

    public void View()
    {
        HrOfExam = int.Parse(Console.ReadLine());
        MinOfExam = int.Parse(Console.ReadLine());
        HrAraived = int.Parse(Console.ReadLine());
        MinAraived = int.Parse(Console.ReadLine());
        var model = new Model.ExamModel(Status, HrOfExam, MinOfExam, HrAraived, MinAraived, MinLateOREarly, HrLateOREarly);
        var controler = _controler.ExamServiceCal(model);
        Console.WriteLine("You are " + model.Status);
        if(model.MinLateOREarly > 59)
        {
            model.HrLateOREarly += model.MinLateOREarly / 60;
            model.MinLateOREarly = model.MinLateOREarly - 60;
        }
        if (model.MinLateOREarly < 10)
        {
            Console.WriteLine(model.HrLateOREarly + ":0" + model.MinLateOREarly);
        }
        else
        {
            Console.WriteLine(model.HrLateOREarly + ":" + model.MinLateOREarly);
        } 
    }
}
