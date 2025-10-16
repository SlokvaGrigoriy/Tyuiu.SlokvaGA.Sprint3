using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SlokvaGA.Sprint3.Task1.V6.Lib
{
    public class DataService : ISprint3Task1V6
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSer = 0;
            while (startValue <= stopValue)
            {
                SumSer += (Math.Pow(value, startValue) + 1) * Math.Sin(startValue);
                startValue++;
            }
            return Math.Round(SumSer, 3);
        }
    }
}