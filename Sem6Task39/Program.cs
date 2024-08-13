// Задача №39
// Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1)
// менять числа местами в исходном массиве; 2) создать
// новый массив и в него записать перевёрнутый исходный
// массив по элементам.

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

int[] SwapNewArray(int[] array)
{
    int[] outArr = new int[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        outArr[array.Length - 1 -i] = array[i];
    }
    return outArr;
}

void SwapArray(int[] array)
{
    int tempElm = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        tempElm = array[array.Length - 1 - i ];
        array[array.Length - 1 - i ] = array[i];
        array[i]=tempElm;
        // (array[array.Length -1 - i], array[i]) = (array[i], array[array.Length - 1 - i]); При это не нужна строка int tempElm = 0;
    }
}

int[] array = GenArray(9, 0, 10);
Console.WriteLine("Исходный массив: ");
PrintArr(array);
int[] swapArr = SwapNewArray(array);
Console.WriteLine("Перевернутый массив 1: ");
PrintArr(swapArr);

SwapArray(array);
Console.WriteLine("Перевернутый массив 2: ");
PrintArr(array);