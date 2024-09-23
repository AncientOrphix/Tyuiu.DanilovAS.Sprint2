using Tyuiu.DanilovAS.Sprint2.Task2.V5.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task2.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            int x = 4;
            int y = 5;
            bool res = true;
            bool wait = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(res, wait);
        }
    }
}