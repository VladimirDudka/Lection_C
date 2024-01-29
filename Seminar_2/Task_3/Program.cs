﻿// Напишите программу, которая выводит третью с конца
// цифру заданного числа или сообщает, что третьей цифры
// нет.
// 456 => 4
// 7812 => 8
// 91 => Третьей цифры нет


int number = 2145832;
if (number >= 100) // Число минимум трехзначное. От 100 до + бесконечности
{
    int thirdDigitFromEnd = (number / 100) % 10;
    Console.WriteLine($"Третья цифра от {number} с конца: {thirdDigitFromEnd}");
}

else // В числе нет 3 цифры
{
    Console.WriteLine("Третьей цифры нет."); 

}