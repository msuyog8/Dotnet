using  ComputationLib;

class Program
{
    

    public static void Main(String[] args)
    {
        
            Console.Write("Lower Number : ");
            int l = int.Parse(Console.ReadLine());
            Console.Write("Higher Number: ");
            int h = int.Parse(Console.ReadLine());
            var inv = new Computation(l, h);
            
            Console.WriteLine("Future value for riskless investment: {0:0.00}",inv.GetSumOf(l, h,isEven));
            Console.WriteLine("Future value for riskless investment: {0:0.00}",inv.GetSumOf( l,  h, isOdd));
            Console.WriteLine("Future value for riskless investment: {0:0.00}",inv.GetSumOf( l, h, isPrime));
            bool isEven(int e)
            {   
                if (e%2==0)
                return true;
                else
                return false;
            }

             bool isOdd(int o)
            {   
                if (o%2==0)
                return false;
                else
                return true;
            }
            bool isPrime(int p)
            {   
               
                if (p%2==0)
                return false;
                else
                return true;
            }







    }
}