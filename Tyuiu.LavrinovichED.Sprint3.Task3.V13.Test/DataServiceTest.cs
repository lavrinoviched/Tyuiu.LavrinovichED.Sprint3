using Tyuiu.LavrinovichED.Sprint3.Task3.V13.Lib; 

namespace Tyuiu.LavrinovichEd.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "?sd!! 5gh.s!";
            int wait = 5;

            int res = ds.ConvertStringToInt(str); 
            Assert.AreEqual(wait, res); 
        }
    }
}