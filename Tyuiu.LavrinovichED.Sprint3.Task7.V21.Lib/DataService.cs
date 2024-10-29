using tyuiu.cources.programming.interfaces.Sprint3; 

namespace Tyuiu.LavrinovichED.Sprint3.Task7.V21.Lib
{
    public class DataService : ISprint3Task7V21
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueWaitArray;
            int len = (stopValue - startValue) + 1;
            valueWaitArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((((2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x + 3), 2);
                valueWaitArray[count] = y;
                count++;
            }
            return valueWaitArray;
        }
    }
}
