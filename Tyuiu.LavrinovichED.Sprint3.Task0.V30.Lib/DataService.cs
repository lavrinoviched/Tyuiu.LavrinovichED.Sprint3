using tyuiu.cources.programming.interfaces.Sprint3; 

namespace Tyuiu.LavrinovichED.Sprint3.Task0.V30.Lib
{
    public class DataService : ISprint3Task0V30
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multSeries = 0;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                double a = Math.Pow(Math.Sin(i), -10);
                multSeries = multSeries + (1 / a);
                
            }
            return Math.Round(multSeries);
        }
    }
}
