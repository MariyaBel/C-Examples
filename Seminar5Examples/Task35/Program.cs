// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void InputArray(int[] array)// функция заполнения массива числами от -100 до 100
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 101);
}

int SearchNumbers(int[] array)// функция поиска числа в заданном диапазоне
{
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >=10) && (array[i] <=99))
            count++;
    }
    return count;// выводит на экран кол-во элементов с такими значением
}

int[] array = new int[123];// создали массив из 123
InputArray(array);// запуск функции заполнение массива
Console.WriteLine("Array: [" + string.Join(", ", array) + "]");// вывод массива на экран
Console.WriteLine("Numbers between 10 and 99 in array: " + SearchNumbers(array));//вывод на экран результата работы функции поиска

