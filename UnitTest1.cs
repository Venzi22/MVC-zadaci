namespace ExamTest
{
    public class Tests 
    {
        [Test]
        public void Test1()
        {
            var test = new Exam.Model.ExamModel("On time", 9, 30, 9, 30, 0, 0);
            Exam.Service.ExamService service = new Exam.Service.ExamService();
            var result = service.ServiceCal(test);
            Assert.AreEqual("On time", test.Status);
        }
    }
}
