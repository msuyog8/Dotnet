namespace DemoApp.Shopping;

public class NewCourse
{
    public string Id { get; set; }

    public int CourseId { get; set; }

    public int Fees { get; set; }

    //navigation property
    public List<NewStudent> NewStudents { get; set; }
}