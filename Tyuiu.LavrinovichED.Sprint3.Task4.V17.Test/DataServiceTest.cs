using Tyuiu.LavrinovichED.Sprint3.Task4.V17.Lib;

namespace Tyuiu.LavrinovichED.Sprint3.Task4.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.527;

            Assert.AreEqual(res, wait);
        }
    }
}