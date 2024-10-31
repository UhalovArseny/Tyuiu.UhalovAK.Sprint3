using Tyuiu.UhalovAK.Sprint3.Task6.V5.Lib;
namespace Tyuiu.UhalovAK.Sprint3.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.GetSumTheDivisors(15, 22);
            Assert.AreEqual(41, res);
        }
    }
}