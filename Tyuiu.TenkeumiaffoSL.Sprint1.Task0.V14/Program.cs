﻿using Tyuiu.TenkeumiaffoSL.Sprint1.Task0.V14.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1";

Console.WriteLine("**************************************************");
Console.WriteLine("* Спринт #1");
Console.WriteLine("* Темв: Базовые навыки работы в C#");
Console.WriteLine("* Вариант #14");
Console.WriteLine("* Задание #0");
Console.WriteLine("Выполнил: Миаффо Тенкеу Лоик Сэмюэль | ИСТНб-25-1");
Console.WriteLine("**************************************************");
Console.WriteLine("* УСЛОВИЕ:");
Console.WriteLine("* Написать программу, которая вычисляет выражение 2*3*3+7 и печатает результат на экране.");
Console.WriteLine("**************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:");
Console.WriteLine("2*3*3+7");
Console.WriteLine("**************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:");
Console.WriteLine(ds.Calculate());
Console.ReadLine();
