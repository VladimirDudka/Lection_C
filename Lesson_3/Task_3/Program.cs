//  Задача 3
//
//  Метод который обнуляет четные числа массива

void ZeroEventElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}


void PrintArray(int[] arr)
{
    for (int e = 0; e < arr.Length; e++ )
    {
        Console.Write($" {arr[e]} ");
    }
    Console.WriteLine();
}

int[] array = {5, 3, 9, 7, 1};
ZeroEventElements(array);
PrintArray(array);






