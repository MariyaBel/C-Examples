//Задана последовательность нат. чисел, заканчивающаяся числом 0.
// Определите значение второго по величине числа в этой последовательности
//1 7 9 0 => 7
//1 2 3 4 5 6 7 0 8 9 10 => 6


// Решение через массив. Метод поиска второго по величине максимального числа в массиве
void FindSecondMax(int[] array)
{
    // Выводим в консоль полученный массив
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    // Определяем максимум среди первой пары чисел массива
    int max = array[0];
    int max2nd = array[1];
    if (max2nd > max)
        {max = array[1]; max2nd = array[0];}

    // Прогоняем остальную часть массива
    for (int j = 2; j < array.Length; j++)
    {
        if (array[j] > max) { max2nd = max; max = array[j]; }
        else if (array[j] > max2nd) max2nd = array[j];
        if (array[j] == 0) break;   // Прерываем перебор массива, когда достигнут 0
    }
    Console.WriteLine($"Second max is: {max2nd}");
}

int[] arr1 = { 1, 7, 9, 0 };
int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 0, 9, 10 };
int[] arr3 ={9,8,3,0,4,5,3,0};

FindSecondMax(arr1);
FindSecondMax(arr2);
FindSecondMax(arr3);



