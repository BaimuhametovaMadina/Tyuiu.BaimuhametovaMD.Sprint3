using Tyuiu.BaimuhametovaMD.Sprint3.Task1.V10.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint3.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculationValid()
        {
            DataService ds = new DataService();
            int x = 5, startValue = 1, endValue = 17;
            double res = ds.GetSumSeries(x, startValue, endValue);
            Assert.AreEqual(0.168, res);
        }
    }
}