// Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Вводим данные
int ReadData(string msg)
{
Console.WriteLine(msg);
int num = int.Parse(Console.ReadLine() ?? "0");
return num;
}

// Печатает массив
void Print2DArray(int[,] array) 
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

// Считает сумму индексов
void Fill2DSumInd(int[,] array, int m, int n)
{
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
}

int m = ReadData("Введите m: ");
int n = ReadData("Введите n: ");

int[,] array = new int[m, n];
Fill2DSumInd(array, m, n);
Print2DArray(array);