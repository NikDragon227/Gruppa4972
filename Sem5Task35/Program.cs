﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//Генерация массива
int[] GenArray(int num, int lowBorder, int highBorder){
    int[] array = new int[num];

    for(int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(lowBorder, highBorder + 1);
    }

    return array;
}

//Печатаем массив
void PrintArr(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//Поиск элемента
int CountElm(int[] arr, int x, int y)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= x && arr[i] <= y)
        {
            count++;
        }
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}


// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(123, 0, 30);
PrintArr(array);
int x = 10;
int y = 99;
int count = CountElm(array, x, y);
PrintResult($"{count} элементов в заданном диапазоне");
