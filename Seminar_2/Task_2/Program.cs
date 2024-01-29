


int number = 122;
int secondDigit = number / 10 % 10; // 947 / 10 % 10 = 94 % 10 = 4
int thirdDigit = number % 10; // 947 % 10 = 7
// Math.Pow(5, 2) => 5 ^ 2 = 5 * 5 = 25
int result = (int)Math.Pow(secondDigit, thirdDigit);

Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");

