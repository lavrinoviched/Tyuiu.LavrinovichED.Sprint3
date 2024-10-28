using Tyuiu.LavrinovichED.Sprint3.Task4.V17.Lib; 

namespace Tyuiu.LavrinovichED.Sprint3.Task4.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Лавринович Е.Д. | АСОиУБ - 24-1";
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* Спринт #3                                                                                        *");
            Console.WriteLine("* Тема: Использование операторов continue и break в циклах                                         *");
            Console.WriteLine("* Задание #3                                                                                       *");
            Console.WriteLine("* Вариант #13                                                                                      *");
            Console.WriteLine("* Выполнила: Лавринович Елизавета Дмитриевна | АСОиУБ - 24-1                                       *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                         *");
            Console.WriteLine("* На отрезке, где х принимает значения от -5 до 5, вычислить значение y = cos(x)/sin(x)            *");
            Console.WriteLine("* При х = 0 прервать цикл. Полученные значения перемножить                                         *");
            Console.WriteLine("*                                                                                                  *");
            Console.WriteLine("****************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
            Console.WriteLine("****************************************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine(" Старт шага = " + startValue);
            Console.WriteLine(" Конец шага = " + stopValue); 

            Console.WriteLine(" Произведение ряда = " + ds.Calculate(startValue, stopValue)); 

            Console.ReadKey(); 
        }
    }
}
