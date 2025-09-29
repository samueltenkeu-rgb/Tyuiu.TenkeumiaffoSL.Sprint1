using System;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TenkeumiaffoSL.Sprint1.Task6.V1.Lib
{
    public class DataService : ISprint1Task6V1
    {
        public string SymbolCode(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return "Строка пуста";
            }

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < value.Length; i++)
            {
                char symbol = value[i];
                int code = (int)symbol;

                result.Append($"'{symbol}' = {code}");

                if (i < value.Length - 1)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }
    }
}