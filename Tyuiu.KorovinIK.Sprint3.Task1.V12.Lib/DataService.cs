using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorovinIK.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            int i = startValue;
            while (i <= stopValue)
            {
                SumSeries = SumSeries + Math.Pow(1 / Math.Pow(i, value), 2);
                i++;
            }

            return Math.Round(SumSeries, 3);
        }
    }
}

