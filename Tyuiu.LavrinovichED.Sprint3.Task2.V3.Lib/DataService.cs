using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LavrinovichED.Sprint3.Task2.V3.Lib
{
    public class DataService : ISprint3Task2V3
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double res = 0;
            int k = 1;
            stopValue = 15;
            do
            {
                res += (Math.Pow(4, 2) * k) + 1;
                k++;
            } while (k <= stopValue);
            return Math.Round(res, 3);
        }
    }
}
