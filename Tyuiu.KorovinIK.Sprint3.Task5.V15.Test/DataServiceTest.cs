using Tyuiu.KorovinIK.Sprint3.Task5.V15.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VailGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 548.732;

            Assert.AreEqual(wait, res);
        }
    }
}
