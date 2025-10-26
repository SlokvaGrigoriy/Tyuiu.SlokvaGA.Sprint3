using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SlokvaGA.Sprint3.Task7.V12.Lib
{
    public class DataService : ISprint3Task7V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                valueArray[i] = Math.Round(Math.Sin(x) + 2 / (3 * x + 0.5) - 2 * Math.Cos(x) * 2 * x, 2);
            }
            return valueArray;
        }
    }
}
