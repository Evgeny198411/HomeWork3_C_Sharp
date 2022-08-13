﻿/*
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

void tableCubes (int n)
{
    for(int i = 1; i <= n; i++)
    {
        Console.Write(Math.Pow(i, 3) + " ");
    }
    Console.WriteLine();
    return;
}

Console.WriteLine("Введите число");
tableCubes(int.Parse(Console.ReadLine()));