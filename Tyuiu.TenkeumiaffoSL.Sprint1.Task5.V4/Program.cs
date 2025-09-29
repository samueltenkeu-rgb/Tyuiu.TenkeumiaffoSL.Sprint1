using Tyuiu.TenkeumiaffoSL.Sprint1.Task5.V4.Lib;

Console.Title = "Спринт #1 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #4                                                              *");
Console.WriteLine("* Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1                       *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Идет k-я секунда суток. Определить, сколько полных часов (h) прошло     *");
Console.WriteLine("* к этому моменту (например, h=3, если k=13257).                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество секунд (k): ");
int time = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.SecondsToHours(time);
Console.WriteLine($"Прошло полных часов: {result}");

Console.ReadLine();