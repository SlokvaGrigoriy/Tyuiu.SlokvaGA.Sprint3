using Tyuiu.SlokvaGA.Sprint3.Task6.V25.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 16;
            int stopValue = 24;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 302;

            Assert.AreEqual(wait, res);
        }
    }
}
