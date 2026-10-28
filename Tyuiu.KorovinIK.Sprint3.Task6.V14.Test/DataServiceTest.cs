using Tyuiu.KorovinIK.Sprint3.Task6.V14.Lib;
namespace Tyuiu.KorovinIK.Sprint3.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void VailGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 7;
            int stopValue = 16;

            int res = ds.GetSumTheDivisors(startValue, stopValue);

            int wait = 12;

            Assert.AreEqual(wait,res);

        }
    }
}
