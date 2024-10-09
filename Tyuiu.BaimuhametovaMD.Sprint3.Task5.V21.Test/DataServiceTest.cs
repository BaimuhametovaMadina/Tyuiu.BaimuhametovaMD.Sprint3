using Tyuiu.BaimuhametovaMD.Sprint3.Task5.V21.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint3.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int x = 2, start1 = 1, end1 = 3, start2 = 1, end2 = 10;
            Assert.AreEqual(25.981, ds.GetSumSumSeries(x, start1, start2, end1, end2));
        }
    }
}