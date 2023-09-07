//Задача № 0
//Написать программу, которая на входе принимает число
//выдает его в квадрате

Console.WriteLine("Введите число: ");

string inputNum = Console.ReadLine();

if(inputNum!=null)
{
    int num = int.Parse(inputNum);

    int res = num*num;

    Console.WriteLine(res);
}