// // Задача №42
// // Напишите программу, которая будет
// // преобразовывать десятичное число в двоичное.
// // Например:
// // 45 -> 101101
// // 3 -> 11
// // 2 -> 10

// Вывод сообщения и запись введённых данных
int Prompt(string message)
{
Console.Write(message);
string value = Console.ReadLine()??",";
int number = Convert.ToInt32(value);

return number;
}

// Конвертация в двоичную систему исчисления
string DecToBin(int num)
{
    string line = string.Empty; //""

    while (num > 0)
    {
        line = num % 2 + line;
        num = num / 2;
    }
    return line;
}

// Переводит число в двоичное
string DecToBinRec(int number)
{
return number == 0 ? "" : DecToBin(number / 2) + Convert.ToString(number % 2);
}

int number = Prompt("Введите число: ");

Console.Write($"Двоичное представление числа: {DecToBin(number)}");
Console.WriteLine();
Console.Write($"Двоичное представление числа: {DecToBinRec(number)}");
Console.WriteLine();
Console.WriteLine(Convert.ToString(number, 2));
Console.WriteLine(Convert.ToString(number, 8));
Console.WriteLine(Convert.ToString(number, 16));