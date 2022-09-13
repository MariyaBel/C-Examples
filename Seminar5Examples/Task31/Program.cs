// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка 
//[-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.


void InputArray(int[] array)// метод  рандомного заполнения массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int SummaPositive(int[] array)//метод поиска суммы положит элементов
{
    int summa_p = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            summa_p += array[i];
    }
    return summa_p;
}

int SummaNegative(int[] array)// метод поиска суммы отрицат элементов
{
    int summa_n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
            summa_n += array[i];
    }
    return summa_n;
}

int[] arr = new int[12];// задали новый массив из 12 эл-тов
InputArray(arr);// запустили функцию рандомного заполнения массива
Console.WriteLine("Array: [" + string.Join(", ", arr) + "]");// вывели массив на экран
Console.WriteLine("Sum of positive elements: " + SummaPositive(arr));// вывели на экран результат функции сумма положит
Console.WriteLine("Sum of negative elements: " + SummaNegative(arr));// вывели на экран результат функции сумма отрицат

