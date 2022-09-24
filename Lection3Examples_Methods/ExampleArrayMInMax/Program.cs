// Упорядочивание массива от мин к макс

int[] arr = { 1, 4, 5, 2, 3, 1, 8, 8 };

void PrintArray(int[] array)//метод вывода массива на экран
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void SelectionSort(int[] array)// метод сортировки массива МинМакс выборкой
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
