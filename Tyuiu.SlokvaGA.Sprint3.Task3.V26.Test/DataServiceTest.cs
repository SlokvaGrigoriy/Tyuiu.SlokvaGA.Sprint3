using Tyuiu.SlokvaGA.Sprint3.Task3.V26.Lib;

namespace Tyuiu.SlokvaGA.Sprint3.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "have a nice time";
            char letter = 'e';

            int res = ds.GetCharCount(str, letter);
            int wait = 3;

            Assert.AreEqual(wait, res);
        }
    }
}
