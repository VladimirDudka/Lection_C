// Цикл For ...
// В цикле for в теле цикла задаётся,
// перемен. счётчик, условие, и изменение условия
// for (int i = 0; i < 10; i++)
//


// Проход по элементам массива 
int[] array = {2,4,6,8,10};
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine($"End array.");


// Задача, где число итераций фиксировано
int n = 100;
int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum = sum + i;
}
Console.WriteLine(sum);


