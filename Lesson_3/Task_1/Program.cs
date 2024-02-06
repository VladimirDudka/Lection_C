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
    double denumenator = c + b;
    double result = numenator / denumenator;
    return result;
}

//CalculateFormula(3,-3,6,-6);
double total = CalculateFormula(7,-3,1,-6);
Console.Clear();
Console.WriteLine(total);



