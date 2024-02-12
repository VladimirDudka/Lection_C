// Задача 1
// Напишите программу, которая бесконечно 
// запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

Console.Clear();
Console.WriteLine("Программа завершается при вводе одиночного символа (q), ");
Console.WriteLine("или при вводе числа, сумма цифр которого чётная.");

bool flag = true;
while (flag) 
{
    Console.Write("Введите текст: ");
    string text = Console.ReadLine()!;
    if (text == "q")
    {
        Console.Clear();
        Console.WriteLine($"Введен символ (q), выход из программы.");
        flag = false;
    }
    int number; // 0, если есть символы ИЛИ само число
    if (int.TryParse(text, out number)) // true, строка состоит только из цифр
    {
        int enter_console = number;
        int last = 0;
        int sum = 0;
        if (number != 0)
        {
            while(number != 0)
            {
                last = number % 10;
                number = number / 10;
                sum = sum + last; 
            
            }

        } 
          if (sum % 2 == 0)
        {
            Console.Clear();
            Console.WriteLine($"Введено число {enter_console}, сумма чисел которого является чётной {sum}.");
            Console.WriteLine("Выход из программы!");
            flag = false;
        }  
    
    }
    Console.WriteLine();
}    