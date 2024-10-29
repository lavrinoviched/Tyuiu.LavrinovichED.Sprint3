using Tyuiu.LavrinovichED.Sprint3.Task6.V14.Lib;

namespace Tyuiu.LavrinovichED.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = 7;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            double wait = 1;

            Assert.AreEqual(res, wait);
        }
    }
}