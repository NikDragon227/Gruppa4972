// Задача №40
// Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
// треугольник с сторонами такой длины.

//Ввод данных пользователя
double ReadData()
{
return double.Parse(Console.ReadLine()?? "0");
}


//Проверка равенства сторон треугольника
bool TriambleTest(double a, double b, double c)
{
    // bool res = true;
    // if (a + b < c) res = false;
    // if (b + c < a) res = false;
    // if (a + c < b) res = false;
    return !(a + b <= c || b + c <= a || a + c <= b);
    // return res;
}

Console.WriteLine(TriambleTest(ReadData(), ReadData(), ReadData()));