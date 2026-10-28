using Tyuiu.KorovinIK.Sprint3.Task6.V14.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task6.V14
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

            Console.WriteLine("* : Обработка целочисленной информации               *");

            Console.WriteLine("* Задание #6                                                      *");

            Console.WriteLine("* Вариант #14                                                         *");

            Console.WriteLine("* Выполнил: Коровин Илья Константинович | ИСТНб-26-1                       *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* УСЛОВИЕ:                                                                  *");

            Console.WriteLine("   *");

            Console.WriteLine("*                                                                          *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");

            Console.WriteLine("*****************************************************************************");

            
            int startValue = 7;
            int stopValue = 16;
            

            
            Console.WriteLine("Начало отрезка " + startValue);
            Console.WriteLine("Конец отрезка " + stopValue);
            
            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");

            Console.WriteLine("*****************************************************************************");

            Console.WriteLine("Число делеителей = " + ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }

}