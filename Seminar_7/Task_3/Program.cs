//  Задайте значение N. 
//  Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
//Пример : 
// N = 5 => 1 2 3 4 5
// start = 1, end = N

void ShowNumbers(int start, int end)
{
    // Базовый случай
    if(start == end)
    {
        //Console.Clear();
        Console.Write($"{start} ");
        Console.WriteLine("END.");
        return;
    }
    // Рекурсивный случай
    Console.Write($"{start} ");
    ShowNumbers(start + 1, end);

    // Раскручивание рекурсии
    Console.Write($"{start} ");
}

ShowNumbers(5,17);