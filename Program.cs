﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = number1 / 10;
int number3 = number2 % 10;

Console.WriteLine($"Вторая цифра числа {number1} -> {number3} ");


            


