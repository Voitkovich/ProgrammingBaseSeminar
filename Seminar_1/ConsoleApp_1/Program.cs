﻿// Программа, которая принимает на вход целое число и выдает его квадрат.

// Запрос от пользователя
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Квадрат исходного числа
int sqrNumber = number * number;

// Вывод результата на экран
Console.WriteLine($"Квадрат вашего числа = {sqrNumber}");

