using Tyuiu.LavrinovichED.Sprint3.Task2.V3.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 4;
            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 7245075375;

            Assert.AreEqual(res, wait); 
        }
    }
}