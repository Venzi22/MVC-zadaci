using Exam.Model;
namespace Exam.Service;

public class ExamService
{
    private int _onTime ;
    public int ServiceCal(ExamModel model)
    {
        if (model.HrOfExam > 23 || model.HrAraived > 23)
        {
            throw new Exception("Invalid hour (it must be less then 23) !!!");
        }
        if (model.MinOfExam > 59 || model.MinAraived > 59)
        {
            throw new Exception("Invalid min (it must be less then 59) !!!");
        }

        _onTime = model.MinOfExam - 30;

        if (model.HrOfExam == model.HrAraived)
        {

            if (model.MinAraived < _onTime)
            {
                model.Status = "Early";
                model.MinLateOREarly = model.MinOfExam - model.MinAraived;
            }
            else if (model.MinAraived > model.MinOfExam)
            {
                model.Status = "Late";
                model.MinLateOREarly = model.MinAraived - model.MinOfExam;
            }
            else if (model.MinAraived >= _onTime || model.MinAraived <= model.MinOfExam)
            {
                model.Status = "On time";
            }
        }
        else if (model.HrAraived > model.HrOfExam)
        {
            model.Status = "Late";
            model.HrLateOREarly = model.HrAraived - model.HrOfExam;
            if (model.MinAraived > 59)
            {
                model.MinLateOREarly = (model.HrLateOREarly * 60 + model.MinAraived) - model.MinOfExam;
            }
            else
            {
                model.MinLateOREarly = model.MinAraived - model.MinOfExam;
            }
        }
        else
        {
            model.Status = "Early";
            model.HrLateOREarly = model.HrOfExam - model.HrAraived;
            if (model.MinAraived > 59)
            {
                model.MinLateOREarly = (model.HrLateOREarly * 60 + model.MinOfExam) - model.MinAraived;
            }
            else
            {
                model.MinLateOREarly = model.MinOfExam -model.MinAraived;
            }
        }
        return model.HrLateOREarly;
    }
}
