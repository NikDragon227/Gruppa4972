// Отсортировать массив методом пузырька

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

//Сортировка массива методом пузырька
int[] BubbleSort(int[] unsorted)
{
    int temp = 0;

    for (int i = 0; i < unsorted.Length - 1; i++) 
    {
        for (int j = 0; j < unsorted.Length - (1 + i); j++)
        {
            if (unsorted[j] > unsorted[j + 1])
            {
                temp = unsorted[j + 1];
                unsorted[j + 1] = unsorted[j];
                unsorted[j] = temp;
            }
        }
    }
    return unsorted;
}

int[] array = GenArray(9, 0, 1000);
PrintArr(array);
PrintArr(BubbleSort(array));