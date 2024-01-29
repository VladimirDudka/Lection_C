﻿// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.

// Примеры
// а = 256 => 26
// b = 891 => 81


int number = 453;
int firstDigit = number / 100; // 453 / 100 = 4
int thirdDigit = number % 10; // 453 % 10 = 3
int result = firstDigit * 10 + thirdDigit; // 4 * 10 + 3 = 43
// $"Текст {result} текст {a+100} текст {a - 500}"
Console.WriteLine($"В числе {number} => {result}");

