Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100 && num < 1000)
{
    int lastDigit = num % 10;

    Console.WriteLine("Последняя цифра числа: " + lastDigit);
}
else
{
    Console.WriteLine("Число не трехзначное.");
}