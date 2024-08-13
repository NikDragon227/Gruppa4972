// Задача №45
// Напишите программу, которая будет создавать
// копию заданного одномерного массива с помощью
// поэлементного копирования.

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
void PrintArr(string msg, int[] array)
{
    Console.Write(msg);
    Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

// Создание копии массива с помощью поэлементного копирования
int[] CopyArray(int[] array)
{
    int[] copiedArray = new int[array.Length];
    // перебор элементов
    for (int i = 0; i < array.Length; i++)
    {
        copiedArray[i] = array[i];
    }
    return copiedArray;
}

int[] array = GenArray(12, -9, 9);
PrintArr("Оригинальный массив: ", array);
int[] copiedArray = CopyArray(array);
PrintArr("Скопированный массив: ", copiedArray);