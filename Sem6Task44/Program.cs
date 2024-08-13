// Задача №44
// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например:
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Вводим данные
int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

// Метод Фибоначчи
void PrintFibNum(int num)
{
    int buf = 0;
    int first = 0;
    int second = 1;
    
    for (int i = 0; i < num; i++)
    {
        Console.Write(first + "_");
        buf = first + second;
        first = second;
        second = buf;
    }
}

int num = ReadData("Введите количество чисел Фибоначчи: ");
PrintFibNum(num);