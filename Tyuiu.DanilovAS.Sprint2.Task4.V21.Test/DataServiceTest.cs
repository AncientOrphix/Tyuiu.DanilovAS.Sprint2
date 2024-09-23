using Tyuiu.DanilovAS.Sprint2.Task4.V21.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task4.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 5;
            var wait = 66.132;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}