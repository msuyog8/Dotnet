
namespace Patientlib;
class Program
{

    public static void Main(string [] args)
    {
       int id = int.Parse(args[0]);
        string name = (args[1]);
        int day = int.Parse(args[2]);
        int c = int.Parse(args[3]);

        var p1 = new Patientlib.Patient(day , c);
        double result = p1.getBillAmount(day,c);
        
    Console.WriteLine($"The Patient's id is {id} and name is {name} ");
    Console.WriteLine($"The total bill amount is {result}");

    }
}
