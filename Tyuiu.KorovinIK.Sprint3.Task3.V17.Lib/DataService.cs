using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KorovinIK.Sprint3.Task3.V17.Lib
{
    public class DataService : ISprint3Task3V17
    {
        public int ConvertStringToInt(string value)
        {
            string digits = "";
            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    digits += c;
                }
            }
            int number = Int32.Parse(digits);
            return number;
        }
    }
}
