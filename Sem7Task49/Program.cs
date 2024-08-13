// Задача №49
// Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти
// элементы на их квадраты.
// Например:
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

// Печатает массив
void SecondPrint2DArray(int[,] array) 
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

// Генерирует массив
int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
{
    System.Random rnd = new System.Random();
    int[,] array2D = new int[countRow, countColumn];

    for(int i = 0; i < countRow; i++)
    {
        for(int j = 0; j < countColumn; j++)
        {
            array2D[i ,j] = rnd.Next(downBorder, topBorder);
        }
    }
    return array2D;
}

// Возводит четные индексы в квадрат
void Update2DArray(int[,] array2D)
{
    for(int i = 0; i < array2D.GetLength(0); i = i + 2)
    {
        for(int j = 0; j < array2D.GetLength(1);j = j + 2)
        {
            array2D[i, j] = array2D[i, j] * array2D[i, j];
        }
    }
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количетсво столбцов: ");

int[,] array2D = Fill2DArray(row, column, 10, 5);
Print2DArray(array2D);
Update2DArray(array2D);
SecondPrint2DArray(array2D);