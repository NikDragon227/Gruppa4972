// Задача №30
// Напишите программу, которая выводит массив из 8
// элементов, заполненный нулями и единицами в
// случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

int[] GenArr(int count)
{
    int[] arr = new int[count];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int count = ReadData("Введите размер массива");
int[] array = GenArr(count);
PrintArr(array);