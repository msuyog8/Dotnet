using DemoApp.Shopping;

var db = new ShopDbContext();

if(args.Length == 0)
{
    foreach(var d in db.NewStudents)
        Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}", d.Id, d.Name, d.Age, d.NewCourseId, d.Grade );
}
else
{
    string  pno = (args[0]);
    var d = db.NewCourses
                .Where(p => p.Id == pno)
                .Include(p => p.NewStudents)
                .FirstOrDefault();
  //  if(d != null)
    {
        foreach(var s in d.NewStudents)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", s.Id ,s.Name,s.Age, s.NewCourseId, s.Grade );
    }
}
