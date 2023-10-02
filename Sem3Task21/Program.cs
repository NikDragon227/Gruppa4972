int ReadData(string msg)
{
    Console.WriteLine(msg);
    int numQuter = int.Parse(Console.ReadLine()??"0");
return 0;
}

string BuildLine (int n, int pow)
{
    string res = string.Empty;

    for(int i = 1; i <= n; i++)
    {
        res = res + Math.Pow(i, pow) + " ";
    }
    return res;
}



void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int n = ReadData("Введите число");
PrintResult(BuildLine(n, 1));
PrintResult(BuildLine(n, 2));