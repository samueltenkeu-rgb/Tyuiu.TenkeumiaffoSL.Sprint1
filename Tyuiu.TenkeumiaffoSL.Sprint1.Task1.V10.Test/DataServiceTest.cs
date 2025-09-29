using Tyuiu.TenkeumiaffoSL.Sprint1.Task1.V10.Lib;
namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task1.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.00;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);
        }
    }
}
