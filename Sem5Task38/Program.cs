// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите
// разницу между первым и последним элементом. Для задачи со звездочкой
// использовать заполнение массива целыми числами

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

//Сортировка массива вставками
void InsertionSort(int[] array)
{
    //Нулевой элемаент массива считается отсортированнной частью
    //Все что справа, то что нужно отсортировать

    for(int i = 0; i < array.Length; i++)
    {
        int temp = array[i];
        int j = i - 1;

        //Сравнение для поиска места в левой части
        while (j >= 0 && array[i] > temp)
        {
            array[j + 1] = array[i];
            array[j] = temp;
            j--;
        }
    }
}

//Обратная сортировка массива подсчетом для произвольного целочисленного диапазона
void CountingSoft (int[] array) 
{
    //Поиск максимального и минимального значения в массиве
    int max = 0;
    int min = 0;
    foreach (int element in array)
    {
        if (element > max) {max = element; }
        else if (element < min) {min = element; }
    }

    //Минимальное значение диапазона к нулю
    int correctionFactor = min != 0 ? -min : 0;
    max += correctionFactor;

    //Создание массива, в котором считаем количество вхождений каджого элемента исходного массива
    int[] count = new int[max +1];
    for (int i = 0; i < array.Length; i++)
    {
        count[array[i] + correctionFactor]++;
    }

    //формируем отсортированный массив
    int index = 0;
    for (int i = count.Length - 1; i >= 0; i--)
    {
        for (int j = 0; j < count[i]; j++)
        {
            array[index] = i - correctionFactor;
            index++;
        }
    }
}

// Вывод результата
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int[] array = GenArray(9, 0, 10);
PrintArr(array);
InsertionSort(array);
PrintArr(array);
CountingSoft(array);
PrintArr(array);
int delta = array[0] - array[array.Length - 1];
PrintResult($"Разница между максимальным и минимальным элементом: {delta}");