using Tyuiu.TenkeumiaffoSL.Sprint1.Task4.V7.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task4.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 4.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3.000, res);
        }

    
    }
}