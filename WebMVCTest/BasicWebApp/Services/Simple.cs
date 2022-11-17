namespace BasicWebApp.Services;

public class Simple : IInterest
{
   
    public int SimpleInterest(int p,int r,int y)
    {
        
        int result =p*r*y;
        return result;
    }
}
