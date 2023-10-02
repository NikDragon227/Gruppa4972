// Задача №28
// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

void PrintResult(string msg)
{
Console.WriteLine(msg);
}

long Fartorial(int num)
{
    long fact = 1;
    
    for(int i = 2; i < num; i++)
    {
        fact = fact * i;
    }
    return fact;
}

int num = ReadData("Введите число: ");

long res = Fartorial(num);

PrintResult($"Произведение чисел от 1 до {num} = {res}");