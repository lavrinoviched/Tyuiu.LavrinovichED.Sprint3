using tyuiu.cources.programming.interfaces.Sprint3; 

namespace Tyuiu.LavrinovichED.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multSeries = multSeries * (i / Math.Pow(Math.Sin(1), -10));
            }
            return Math.Round(multSeries, 3);
        }
    }
}
