//                   В языке C# Функция == Метод.
//  
//  Методы бывают: 1. Которые возвращают значение.
//                 2. void - не возвращает ничего но,
//  void - может иметь "побочный эффект" в виде Пример: Console.WriteLine()

// тип_метода ИмяМетода (пар1, пар2, ....парN)
// a, b - 2 числа, sign - знак арифм. операции
// char - это тип (знак, символ) он выделяется так Пример: '#'
// ВАЖНО: char !== string

double Calculate (int a, double b, char sign) // char - это тип (знак, символ) он выделяется так Пример: '#'
{
    if(sign == '+')
    {
        return a + b;
    }
    else if (sign == '-')
    {
        return a - b;
    }
    else if (sign == '*')
    {
        return a * b;
    }
    else if (sign == '/')
    {
        return a / b;
    }
    else 
    {
        Console.WriteLine($"Введен неверный знак, будьте внимательны!");
        return 0;
    }
}

// Первый способ вывода метода
double var = Calculate(23, 34, '*');
Console.WriteLine($"{var}");

// Второй способ вывода метода
Console.WriteLine(Calculate(212, 34, '/'));

