using Tyuiu.TenkeumiaffoSL.Sprint1.Task7.V29.Lib;

Console.Title = "Спринт #1 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #29                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет математическое выражение:         *");
Console.WriteLine("*        cos(x³)     sin(x⁵)                                              *");
Console.WriteLine("* z = x - --------- + ---------                                           *");
Console.WriteLine("*          xy - 3     xy + 5                                              *");
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