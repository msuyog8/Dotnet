namespace DemoApp.Shopping;

public class NewStudent
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Age { get; set; }

    public string NewCourseId { get; set; } // NewCourse madhali primary key --- NewStudent mdhe as a FK
    public string Grade { get; set; } 
}