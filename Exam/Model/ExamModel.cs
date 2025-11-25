namespace Exam.Model;

public class ExamModel
{
    private string _status;
    public string Status
    {
        get { return _status; }
        set { _status = value; }
    }

    private int _hrOfExam;
    public int HrOfExam
    {
        get { return _hrOfExam; }
        set { _hrOfExam = value; }
    }

    private int _minOfExam;
    public int MinOfExam
    {
        get { return _minOfExam; }
        set {  _minOfExam = value; }
    }

    private int _hrAraived;
    public int HrAraived
    {
        get { return _hrAraived; }
        set { _hrAraived = value; }
    }

    private int _minAraived;
    public int MinAraived
    {
        get { return _minAraived; }
        set { _minAraived = value; }
    }

    private int _minLateOREarly;
    public int MinLateOREarly
    {
        get { return _minLateOREarly; }
        set { _minLateOREarly = value; }
    }

    private int _hrLateOREarly;
    public int HrLateOREarly
    {
        get { return _hrLateOREarly; }
        set { _hrLateOREarly = value; }
    }

    public ExamModel(string status, int hrOfExam, int minOfExam, int hrAraived, int minAraived, int minLateOREarly, int hrLateOREarly)
    {
        Status = status;
        HrOfExam = hrOfExam;
        MinOfExam = minOfExam;
        HrAraived = hrAraived;
        MinAraived = minAraived;
        MinLateOREarly = minLateOREarly;
        HrLateOREarly = hrLateOREarly;
    }
}
