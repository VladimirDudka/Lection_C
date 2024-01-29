// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1


int number = 196;
int secondDigit = number / 10 % 10; // 196 / 10 % 10 = 19 % 10 = 9
int thirdDigit = number % 10; // 196 % 10 = 6
// Math.Pow(5, 2) => 5 ^ 2 = 5 * 5 = 25
int result = (int)Math.Pow(secondDigit, thirdDigit);

Console.WriteLine($"{secondDigit} ^ {thirdDigit} = {result}");

