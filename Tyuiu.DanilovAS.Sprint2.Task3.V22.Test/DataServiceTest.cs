using Tyuiu.DanilovAS.Sprint2.Task3.V22.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 4.5;
            var res = ds.Calculate(x);
            var wait = 1910.836;
            Assert.AreEqual(res, wait);
        }
    }
}