using Tyuiu.KorovinIK.Sprint3.Task0.V6.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task0.V6
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


            int startValue = 1;
            int stopValue = 15;

            Console.Write("Старт шага = " + startValue);
            

            Console.Write("Конец шага = " + stopValue);
            

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Суммы ряда " + ds.GetMultiplySeries(startValue, stopValue));


            Console.ReadKey();
        }
    }

}