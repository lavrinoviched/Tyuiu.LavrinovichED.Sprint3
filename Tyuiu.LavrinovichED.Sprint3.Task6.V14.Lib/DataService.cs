using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LavrinovichED.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int Div = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= stopValue; j++)
                {
                    if ((stopValue % j == 0 && j > 5))
                    {
                        Div++;
                    }
                }
            }

            return Div;
     
        }
    }
}
