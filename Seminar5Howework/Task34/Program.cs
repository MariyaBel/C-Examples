//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

void InputArray(int[] array)// метод  рандомного заполнения массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int NumberofPositive(int[] array)//метод поиска кол-ва четных элементов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i])%2==0)
            count++;
    }
    return count;
}


int[] arr = new int[10];// задали новый массив из 10 эл-тов
InputArray(arr);// запустили функцию рандомного заполнения массива
Console.WriteLine("Array: [" + string.Join(", ", arr) + "]");// вывели массив на экран
Console.WriteLine("Number of even elements: " + NumberofPositive(arr));// вывели на экран результат функции
