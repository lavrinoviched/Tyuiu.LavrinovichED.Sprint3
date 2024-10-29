using Tyuiu.LavrinovichED.Sprint3.Task6.V14.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                                         *");
            Console.WriteLine("* Задание #6                                                                                       *");
            Console.WriteLine("* Вариант #14                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* Написать программу, которая ищет среди целых чисел, принадлежащих чисовому отрезку [7, 16]       *");
            Console.WriteLine("* количество всех делителей больше 5                                                               *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int startValue = 7;
            int stopValue = 16;

            Console.WriteLine(" Старт шага  = " + startValue);
            Console.WriteLine(" Конец шага  = " + stopValue);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(" Количество делителей, которые больше 5 = " + ds.GetSumTheDivisors(startValue, stopValue));

            Console.ReadKey(); 
        }
    }
}
