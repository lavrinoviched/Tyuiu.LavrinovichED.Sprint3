using Tyuiu.LavrinovichED.Sprint3.Task5.V20.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 6;

            double res = ds.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2 );

            double wait = 16839.467; 

            Assert.AreEqual(wait, res); 
        }
    }
}