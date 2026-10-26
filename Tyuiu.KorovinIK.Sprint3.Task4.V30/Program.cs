using Tyuiu.KorovinIK.Sprint3.Task4.V30.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task4.V30
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

            Console.WriteLine("* : Использование операторов continue и break в циклах               *");

            Console.WriteLine("* Задание #4                                                       *");

            Console.WriteLine("* Вариант #30                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            int statValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага " + statValue);
            Console.WriteLine("Конец шага " + stopValue);

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Сумма ряда = " + ds.Calculate(statValue, stopValue));
            Console.ReadKey();
        }
    }
}