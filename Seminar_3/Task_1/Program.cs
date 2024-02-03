// Задайте массив. Напишите программу, которая определяет,
// присутстствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Пример:
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

int [] array = {11, 22, 33, 44, 55, 66, 77, 88, 99};
int numberForSearch = 45;
bool isFound = false; // Создал булевую переменную число не найдено

for (int i = 0; i < array.Length; i++)
{
    if (numberForSearch == array[i])
    {
        isFound = true; // Как только число совпадает isFound меняет
                        // значение на true, число найдено
        break; // Ломает цикл                
    }
    
}
if (isFound) // isFound == true. При таком написании C#
             // всегда сравнивает значение с true
{
    Console.WriteLine($"Да.");
}
else         // isFound == false
{
    Console.WriteLine($"Нет.");
}




