﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA / 10;
int numberC = numberB % 10;
Console.WriteLine($"{numberC} - это вторая цифра числа {numberA}");