using Tyuiu.UhalovAK.Sprint3.Task1.V23.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task1.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 5;

            double res = ds.GetMultiplySeries(value, startValue, stopValue);
            double wait = 0.071;

            Assert.AreEqual(wait, res);
        }
    }
}