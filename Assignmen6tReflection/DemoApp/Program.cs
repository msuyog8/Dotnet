using System.Reflection;

delegate double del(int days, int noPersons);


class Program
{

public static void Main(string[] args)
{
    int d = int.Parse(args[0]);
    int p = int.Parse(args[1]);
    Type t = Type.GetType(args[2]);
    MethodInfo scheme = t.GetMethod(args[3]);
    object policy = Activator.CreateInstance(t);
    del rate = scheme.CreateDelegate<del>(policy);

    double i = rate(d,p);
    Console.WriteLine("Tour Charges are {0}",i);

}

}