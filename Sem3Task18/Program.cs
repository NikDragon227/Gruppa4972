// Ввести номер четверти
// Ответить на вопрос 
// Вывести ответ

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int numQuter = int.Parse(Console.ReadLine()??"0");
return 0;
}

string QuterBorderAsk(int numQuter)
{
if(numQuter == 1) return "x > 0, y > 0";
if(numQuter == 2) return "x > 0, y < 0";
if(numQuter == 3) return "x < 0, y < 0";
if(numQuter == 4) return "x < 0, y > 0";
return string.Empty;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQuter = ReadData("Введите номер четвети: ");

string res = QuterBorderAsk(numQuter);

PrintResult("Диапазон возможных координат " + numQuter);