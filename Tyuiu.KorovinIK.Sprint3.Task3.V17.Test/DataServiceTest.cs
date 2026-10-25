using Tyuiu.KorovinIK.Sprint3.Task3.V17.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task3.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildConvertStringToInt()
        {
            DataService ds = new DataService();

            string str = "*vn98n! b,";
            int res = ds.ConvertStringToInt(str);

            int wait = 98;

            Assert.AreEqual(wait, res );
        }
    }
}
