//Задача №24
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Вводим данные
int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

//Печатаем результат
void PrintResult(string msg)
{
Console.WriteLine(msg);
}

// Действие 

int NumDigit(int num)
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

int num = ReadData("Введите число: ");

int res = NumDigit(num);

PrintResult("Количество цифр в числе " + res);