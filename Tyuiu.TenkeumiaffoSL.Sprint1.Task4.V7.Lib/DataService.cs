using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task4.V7.Lib
{
    public class DataService : ISprint1Task4V7
    {
        public double Calculate(double x, double y)
        {
            if (Math.Abs(x - 3 * y) < 0.0001)
            {
                throw new ArgumentException("Знаменатель равен нулю. Деление на ноль невозможно.");
            }

            if (x * y < 0)
            {
                throw new ArgumentException("Подкоренное выражение x*y не может быть отрицательным.");
            }

            double numerator = 1 + Math.Sqrt(x * y);
            double denominator = Math.Pow(x - 3 * y, 2);
            double result = numerator / denominator;

            return Math.Round(result, 3);
        }
    }
}