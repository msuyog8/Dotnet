namespace ComputationLib;


public class Computation
{
    public delegate bool Check(int m);
    public int Low{get; set;}
    public int High{get; set;}

public Computation(int low,int high)
{
Low = low;
High = high;

}
public double GetSumOf(int Low, int High ,Check chk)
{
     for (int i = Low ; Low<High; Low++)
     {
            bool v = chk.Invoke(Low);
            if(v == true)
            {
                double result =0;
                return  result +Low;
            }

     }
    
}


}
