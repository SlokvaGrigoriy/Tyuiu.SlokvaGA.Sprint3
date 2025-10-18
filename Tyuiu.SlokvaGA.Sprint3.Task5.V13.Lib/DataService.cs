using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SlokvaGA.Sprint3.Task5.V13.Lib
{
    public class DataService : ISprint3Task5V13
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double SumSer = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++)
                for (k = startValue2; k <= stopValue2; k++)
                    SumSer += Math.Cos(x) + (k / 2);
            return Math.Round(SumSer, 3);
        }
    }
}
