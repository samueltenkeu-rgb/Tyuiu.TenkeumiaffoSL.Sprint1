using Tyuiu.TenkeumiaffoSL.Sprint1.Task4.V7.Lib;

Console.Title = "Спринт #1 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет выражение по формуле:             *");
Console.WriteLine("*          1 + √(x*y)                                                    *");
Console.WriteLine("* z = ------------------                                                  *");
Console.WriteLine("*        (x - 3y)²                                                        *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите значение x: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение y: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.Calculate(x, y);
Console.WriteLine($"Результат вычисления = {result:F3}");

Console.ReadLine();