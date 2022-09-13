//  Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void InputArray(int[] array)// метод  рандомного заполнения массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 10);
}

int SumofElements(int[] array)//метод поиска суммы элементов на четных позициях в массиве
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==0)
            sum=sum+array[i];
    }
    return sum;
}


int[] arr = new int[10];// задали новый массив из 10 эл-тов
InputArray(arr);// запустили функцию рандомного заполнения массива
Console.WriteLine("Array: [" + string.Join(", ", arr) + "]");// вывели массив на экран
Console.WriteLine("Number of elements on even places in the array: " + SumofElements(arr));// вывели на экран результат функции
