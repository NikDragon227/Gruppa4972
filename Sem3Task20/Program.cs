// Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

// 1) ReadData  
// 2) Cal2DDist
// 3) PrintResult

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int numQuter = int.Parse(Console.ReadLine()??"0");
return 0;
}

double Cal2DDist(int x, int y)
{
    double res = Math.Sqtr(x*x+y*y);
    return res;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x1 = ReadData("Введите координату X1: ");
int x2 = ReadData("Введите координату X2: ");
int y1 = ReadData("Введите координату Y1: ");
int y2 = ReadData("Введите координату Y2: ");

double res = Cal2DDist((x2 - x1), (y2 - y1));

PrintResult("123" + res);