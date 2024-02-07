// Составные части функций. Тип возвращаемого значения.
// 
// int Square (int value)
// {
//      int result = value * value;
//      return result;
// }
// В заданной функции int Square , int - Тип возвращаемого значения, а
// Square - имя функции, (int value) - входящие параметры из вне

double CalculateFormula(int a, double b, int c, double d)
{
    double numenator = a * b;
    double denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

//CalculateFormula(3,-3,6,-6);
//double total = CalculateFormula(f,1,1,-6);
Console.Clear();
Console.WriteLine($"Введите первое значение (a): ");
int f = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите второе значение (b): ");
double g = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите третье значение (c): ");
int h = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Введите четвертое значение (d): ");
double j = double.Parse(Console.ReadLine()!);

double total = CalculateFormula(f,g,h,j);

Console.Clear();
Console.WriteLine($"Метод CalculateFormula: ({f} * {g}) / ({h} + {j}) = {total}.");
Console.WriteLine();
Console.WriteLine($"Результат вычисления метода \"CalculateFormula\" равен {total}.");
Console.WriteLine();



