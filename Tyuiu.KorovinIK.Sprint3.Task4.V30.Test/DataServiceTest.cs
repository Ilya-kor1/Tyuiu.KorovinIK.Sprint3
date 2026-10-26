using Tyuiu.KorovinIK.Sprint3.Task4.V30.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task4.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VaildCalc()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.962;
            Assert.AreEqual(wait, res);
        }
    }
}
