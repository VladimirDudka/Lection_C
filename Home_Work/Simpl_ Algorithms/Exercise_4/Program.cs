// Задача 4
// Программа на вход принимает натуральное
// число N, а на выходе показывает его цифры
// через запятую Пример: 9542 => 9, 5, 4, 2


int N = 295401854;  // Вводим натуральное число (int)


int count = N;  // Переменная для проверки условий
int var_1 = N;  //  Переменная для выполнения условий
int front_var = 0; //  Переменная для выполнения условий
string last_var = "";

while (count > 0)
{
    int var_3 = var_1 % 10; 
    last_var = last_var + (string) $"{var_3}"; 
    front_var = var_1 / 10;
    count = front_var;
    var_1 = front_var;
    
}


int number = int.Parse(last_var);


int count_1 = number;
int var_11 = number;
int front_var_1 = 0;
string last_var_1 = "";

while (count_1 > 0)
{
    int var_4 = var_11 % 10; 
    last_var_1 = last_var_1 + (string) $"{var_4}"; 
    front_var_1 = var_11 / 10;
    count_1 = front_var_1;
    if (count_1 > 0)
    {
        last_var_1 = last_var_1 + ", ";
    
    }
    else
    {
        last_var_1 = last_var_1 + ".";
    }
    var_11 = front_var_1;

    
}

Console.WriteLine(last_var_1);


