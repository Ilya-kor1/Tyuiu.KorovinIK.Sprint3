using Tyuiu.KorovinIK.Sprint3.Task3.V17.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task3.V17
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

            Console.WriteLine("* :Оператор цикла foreach               *");

            Console.WriteLine("* Задание #3                                                       *");

            Console.WriteLine("* Вариант #17                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            string str = "*vn98n! b,";

            Console.WriteLine("Исходная строка"+  str);

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Количество ряда = " + ds.ConvertStringToInt(str));
            Console.ReadKey();
        }
    }
}