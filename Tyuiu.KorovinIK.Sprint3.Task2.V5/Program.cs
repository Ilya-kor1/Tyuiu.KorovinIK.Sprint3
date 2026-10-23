using Tyuiu.KorovinIK.Sprint3.Task2.V5.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task2.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Коровин И. К. | ИСТНб-26-1";

            Console.WriteLine("***************" +
                "**************************************************************");

            Console.WriteLine("* Спринт #3                                                                *");

            Console.WriteLine("* :Оператор цикла do-while                 *");

            Console.WriteLine("* Задание #2                                                       *");

            Console.WriteLine("* Вариант #5                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            double value = 0.75;
            int startValue = 1;
            int stopValue = 20;

            Console.WriteLine("Значение a = " + value);
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
