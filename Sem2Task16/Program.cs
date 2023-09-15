Console.WriteLine("Введите 1-е число: ");
int firstNum=int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите 2-е число: ");
int secondNum=int.Parse(Console.ReadLine()??"0");

bool test1 = (firstNum == secondNum * secondNum);

bool test2 = (secondNum == firstNum * firstNum);

if (test1)Console.WriteLine("Первое число квадрат второго.");
if (test2)Console.WriteLine("Второе число квадрат первого.");

if(!(test1 || test2))
{
    Console.WriteLine("Числа не квадраты друг друга");
}