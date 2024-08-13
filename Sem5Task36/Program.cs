// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// * Найдите все пары в массиве и выведите пользователю

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

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int SumNegPos(int[] arr) 
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

//Поиск пар и вывод результата
void FindPrintPairs(int[] array)
{
    Console.WriteLine("Пары в массиве: ");

    // Обьявляем словарь <Tkey> число, <Tvalue> будет его индекс в массиве
    Dictionary<int,int> seenNumbers = new Dictionary<int, int>();

    // Для каждого элемента проверяем содержится ли он уже в словаре
    for (int i = 0; i < array.Length; i++)
    {
        if (seenNumbers.ContainsKey(array[i]))
        {
            // Если число содержится в словаре, значит нашли пару. Выводим на экран пару чисел и их адреса в массиве.
            // Само число из словаря удаляем
            Console.WriteLine($"{array[i]},{array[i]} -> [{seenNumbers[array[i]]}], [{i}]");
            seenNumbers.Remove(array[i]);
        
        }
        else
        {// Если число не содержится в словаре, добавляем его
        seenNumbers.Add(array[i],i);
        }
    }
}

// Вызываем генерацию массива, выводим изначальный массив.
int[] array = GenArray(30, 0, 30);
PrintArr(array);
int res = SumNegPos(array);
PrintResult($"{res} сумма чисел, находящихся на нечетный позициях.");
FindPrintPairs(array);
