using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task7.V29.Lib
{
    public class DataService : ISprint1Task7V29
    {
        public double Calculate(double x, double y)
        {
            if (Math.Abs(x * y - 3) < 0.0001)
            {
                throw new ArgumentException("Знаменатель (xy - 3) равен нулю. Деление на ноль невозможно.");
            }

            if (Math.Abs(x * y + 5) < 0.0001)
            {
                throw new ArgumentException("Знаменатель (xy + 5) равен нулю. Деление на ноль невозможно.");
            }


            double xCubed = Math.Pow(x, 3);
            double xFifth = Math.Pow(x, 5);

            double firstFraction = Math.Cos(xCubed) / (x * y - 3);
            double secondFraction = Math.Sin(xFifth) / (x * y + 5);

            double result = x - firstFraction + secondFraction;

            return Math.Round(result, 3);
        }
    }
}