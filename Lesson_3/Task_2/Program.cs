// Задача 2
// Вывод на экран квадратов чисел от 1 до N


// Создаём Метод Square_number()
void Square_number(int lim)
{
    int i = 1;
    while(i <= lim)
    {
        Console.WriteLine($"Квадрат числа {i} равен {i * i}.");
        i++;
    }
}



// Вызов метода Square_number(), в метод передаём
// переменную lim (до какого числа, узнать квадрат этого числа)
Console.Clear();
Square_number(15); // Здесь число можно менять
Console.WriteLine();




