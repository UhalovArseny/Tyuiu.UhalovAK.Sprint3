using Tyuiu.UhalovAK.Sprint3.Task2.V22.Lib;

namespace Tyuiu.UhalovAK.Sprint3.Task2.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int x = 5;
            int i = 1;
            int j = 7;

            double res = ds.GetMultiplySeries(x, i, j);
            double wait = 10.763;

            Assert.AreEqual(wait, res);
        }
    }
}