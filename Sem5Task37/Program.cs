// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10


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

//Конвертируем массив
int[] ConvertArr(int[] arr)
{
    int[] outArr = new int[arr.Length/2];
    for(int i = 0; i < arr.Length/2; i++)
    {
        outArr[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    return outArr;
}


int[] array = GenArray(10, 0, 30);
PrintArr(array);
PrintArr(ConvertArr(array));
