using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SlokvaGA.Sprint3.Task2.V11.Lib
{
    public class DataService : ISprint3Task2V11
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            do
            {
                SumSeries += Math.Pow(1 / (3 + Math.Pow(value, startValue)), startValue);
                startValue++;
            } while (startValue <= stopValue);
            return Math.Round(SumSeries, 3);
        }
    }
}