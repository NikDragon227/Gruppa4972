// Задача №51
// Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с
// индексами (0,0); (1;1) и т.д.
// Например:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

// Расчитываем главную диагональ
int MainDiagSum (int[,] matrix)
{
    int res = 0;
    int min = (matrix.GetLength(0));
    if(min > matrix.GetLength(1)) 

    min = matrix.GetLength(1);
    
    for(int i = 0; i < min; i++)
    {
        res = res + matrix[i,i];
    }
    return res;
}

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количетсво столбцов: ");

int[,] array2D = Fill2DArray(row, column, 10, 5);
Print2DArray(array2D);
int sum = MainDiagSum(array2D);
Console.Write("Сумма главной диагонали массива: " + (sum));