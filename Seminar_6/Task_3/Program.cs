// Считать строку с консоли, состоящую из
// латинских букв в нижнем регистре.
//Выяснить, сколько среди введённых букв гласных.
// "Hello" => 2 ; "world" => 1

int GetVovelsCount(string text) // Метод считающий кол-во гласных
{
  string vovels = "aoueyi"; // Гласные буквы в англ. алфавите. Помещены в одну строку
  int vovelsCount = 0; // счётчик гласных букв. Старт = 0
  foreach (char symbol in text) // Берём каждый символ введённого текста по очереди
  {
    foreach (char vovel in vovels)  // Берём каждый символ гласной буквы (из строки vovels) по очереди
    {
        if(symbol == vovel) // если буквы совпали (Нашли гласную букву)
        {
            vovelsCount++; // Счётчик гласных +1
            break; // эту букву введеного текста больше не проверяем
                   // т.к. на одном месте не может быть двух символов, переходим к след.
        }
    }
  }
  return vovelsCount;  
}
Console.Clear();
Console.Write("Введите строчку: ");
string inputString = Console.ReadLine()!;
inputString = inputString.ToLower(); // Переводим всё в нижний регистр
Console.WriteLine(inputString);
Console.WriteLine($"Введенном тексте - {GetVovelsCount(inputString)} гласных букв.");
Console.WriteLine();