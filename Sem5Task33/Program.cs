// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Генерация одномерного массива

int[] GenArray(int num, int lowBorder, int highBorder){
    int[] array = new int[num];

    for(int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
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

int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

void PrintData(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int FindElm(int[] arr, int elm)
{
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == elm)
        {
            return i;
        }
    }
        return -1;
}

int[] array=GenArray(12,-9, 9);
PrintArr(array);
int elm = ReadData("Введите число: ");
Console.WriteLine($"Число {elm} встречается в массиве на {FindElm(array, elm)} месте");