using Tyuiu.DanilovAS.Sprint2.Task7.V11.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;

            var res = ds.CheckDotInShadedArea(x, y);
            var wait = false;
            Assert.AreEqual(res, wait);
        }
    }
}