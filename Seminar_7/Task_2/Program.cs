//  Напишите программу, которая на вход принимает
//  натуральное число и возвращает сумму его цифр.
//Пример: 
// 123 => 6
// 63 => 9

int SumDigits(int d)
{
    //int number = d;
    

    if(d == 0)
    {
        
        return 0 ;
    }
int result = d % 10 + SumDigits(d / 10);
    return result;
}

Console.WriteLine(SumDigits(383));