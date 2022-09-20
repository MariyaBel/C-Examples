// Задайте массив дробных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3,5 7,78 22 2,23 78, 25] -> 76,02

void InputArray(double[] array)// метод рандомного заполнения массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round((new Random().Next(-100, 101)) + (new Random().NextDouble()),2);//вещест числами
        // число в массиве = округленное до 2 знаков число от (-100 до 101) + любое дробное число
        //Math.Round - число округляем до x знаков после запятой
}

void DiffMaxMin(double[] array)//метод поиска разницы между максимум и минимумом в массиве
{
    double min = array[0];
    double max = array[1];
    if (min > max)
    {
        max = min;
        min = array[0];
    }

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
        if (array[i] > max)
            max = array[i];
    }
    Console.WriteLine("Difference between max and min is: " + (max - min));
}


double[] arr = new double[10];// задали новый массив из 10 эл-тов
InputArray(arr);// запустили функцию рандомного заполнения массива
Console.WriteLine("Array: [" + string.Join(", ", arr) + "]");// вывели массив на экран
DiffMaxMin(arr);// запустили функцию