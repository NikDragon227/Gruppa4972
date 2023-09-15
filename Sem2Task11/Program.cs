int num = new Random().Next(100, 1000);

Console.WriteLine(num);

int firstDigit = num/100;

int lastDigit = num%10;

num = firstDigit + lastDigit;

Console.WriteLine(num);
