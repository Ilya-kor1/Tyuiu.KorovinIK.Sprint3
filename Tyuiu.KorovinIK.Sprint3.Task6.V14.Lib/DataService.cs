using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorovinIK.Sprint3.Task6.V14.Lib
{
    public class DataService : ISprint3Task6V14
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {

            int res = 0;
            
            for (int x = startValue; x <= stopValue; x++)
            {
                int count = 0;
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        count++;
                    }
                }
                if (count > 5)
                {
                    res += x;
                }
            }
            return res;

        }
    }
}
