using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            int squaresInWidth = (int)(a / c);
            int squaresInHeight = (int)(b / c);

            double totalSquares = squaresInWidth * squaresInHeight;

            return Math.Round(totalSquares, 3);
        }
    }
}