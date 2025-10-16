using Tyuiu.SlokvaGA.Sprint3.Task1.V6.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task1.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 4;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = -389102.25;

            Assert.AreEqual(res, wait);
        }
    }
}