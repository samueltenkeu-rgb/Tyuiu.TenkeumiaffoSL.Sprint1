using Tyuiu.TenkeumiaffoSL.Sprint1.Task7.V29.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            // z = 1 - cos(1)/(1-3) + sin(1)/(1+5) = 1 - cos1/(-2) + sin1/6
            // = 1 - 0.5403/(-2) + 0.8415/6 = 1 + 0.27015 + 0.14025 = 1.4104
            Assert.AreEqual(1.410, res);
        }

    }
}