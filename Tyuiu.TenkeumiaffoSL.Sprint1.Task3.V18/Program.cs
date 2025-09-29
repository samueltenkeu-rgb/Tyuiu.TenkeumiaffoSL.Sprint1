using Tyuiu.TenkeumiaffoSL.Sprint1.Task3.V18.Lib;

Console.Title = "Спринт #1 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #18                                                             *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет, сколько квадратов со стороной C  *");
Console.WriteLine("* можно разместить внутри прямоугольника с размерами A x B без наложений. *");
Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите сторону A прямоугольника: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сторону B прямоугольника: ");
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите сторону C квадрата: ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
double result = ds.HowManySquares(a, b, c);
Console.WriteLine($"Количество квадратов = {result:F3}");

Console.ReadLine();