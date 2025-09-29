using Tyuiu.TenkeumiaffoSL.Sprint1.Task6.V1.Lib;

Console.Title = "Спринт #1 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая получает коды символов введенной строки.    *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите строку: ");
string value = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
string result = ds.SymbolCode(value);
Console.WriteLine($"Коды символов: {result}");

Console.ReadLine();