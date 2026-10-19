using Tyuiu.KorovinIK.Sprint3.Task1.V12.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* Спринт #3                                                               c *");

            Console.WriteLine("* Тема:Оператор цикла for                 *");

            Console.WriteLine("* Задание #0                                                       *");

            Console.WriteLine("* Вариант #6                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("Написать программу используя цикл for, которая вычисляет произведение ряда по формуле   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Значение n = " + value);
            Console.WriteLine("Начало ряда = " + startValue);
            Console.WriteLine("Конец ряда = " + stopValue);


            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Суммы ряда " + ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
