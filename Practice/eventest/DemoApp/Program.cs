class Odd
{

  public bool isOdd(int n1)
    {
        if ((n1 % 2) != 0)
        {
            return true;  
        }             

        else 
        {
            return false;
        }
    }


}





class Program
{
    public static bool isEven(int n1)
    {
        if ((n1 % 2) == 0)
        {
            return true;  
        }             

        else 
        {
            return false;
        }
    }



    public static void Main(string[] args)
    {
        int num = int.Parse(args[0]);
        bool i = isEven(num);
        if (i == true)
        Console.WriteLine("The number is even");
        else
        Console.WriteLine("The number is odd");

        Odd o = new Odd();

        i = o.isOdd(num);
        if (i == false)
        Console.WriteLine("The number is EVEN");
        else
        Console.WriteLine("The number is ODD");
    }



}