using Tyuiu.TenkeumiaffoSL.Sprint1.Task3.V18.Lib;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 10.0;
            double b = 8.0;
            double c = 2.0;
            var res = ds.HowManySquares(a, b, c);
            Assert.AreEqual(20.000, res); // (10/2) * (8/2) = 5 * 4 = 20
        }

     
    }
}