Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int threeNumber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (firstNumber > max)
{
    max = firstNumber;
}

if(secondNumber > max)
{
    max = secondNumber;
}

if(threeNumber > max)
{
    max = threeNumber;
}

Console.WriteLine(max);