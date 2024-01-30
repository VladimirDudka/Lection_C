// Задача 3
// Программа принимает целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа Пример: 72 => 7, 40 => 4

int value = 45;

if (value >= 10 && value <= 99)  // По условию число из отрезка [10, 99]
{
    int first = value / 10; // Первый знак в цифре
    int second = value % 10; // Второй знак в цифре

    if (first > second)
    {
        Console.WriteLine($"В числе {value} наибольшая цифра {first}.");
    }
    if (first < second)
    {
        Console.WriteLine($"В числе {value} наибольшая цифра {second}.");
    }
    if (first == second)
    {
        Console.WriteLine($"В числе {value} цифра {first} и цифра {second} равны.");
    }

}
else
{
    Console.WriteLine($"По условию число должно находиться в промежутке от 10 до 99.");
}
