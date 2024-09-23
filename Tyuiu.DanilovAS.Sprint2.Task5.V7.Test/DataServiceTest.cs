using Tyuiu.DanilovAS.Sprint2.Task5.V7.Lib;

namespace Tyuiu.DanilovAS.Sprint2.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindMonthName()
        {
            DataService ds = new DataService();
            int n = 4456;
            int startYear = 1990;
            var wait = "Апрель";
            var res = ds.FindMonthName(startYear, n);
            Assert.AreEqual(res, wait);
        }
    }
}