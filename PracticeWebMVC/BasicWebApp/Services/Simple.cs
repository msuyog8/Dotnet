namespace BasicWebApp.Services;

public class Simple : IInterest
{
  
    double IInterest.SimpleInterest(double p, double r, int y)
    {
         return (p * r * y ) / 100;
    }
   
}
