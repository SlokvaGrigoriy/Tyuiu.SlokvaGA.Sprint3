using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SlokvaGA.Sprint3.Task0.V22.Lib
{
    public class DataService : ISprint3Task0V22
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double MS = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
                MS += ((Math.Pow(value, MS) + 4) * Math.Cos(value));
            return Math.Round(MS, 3);
        }
    }
}
