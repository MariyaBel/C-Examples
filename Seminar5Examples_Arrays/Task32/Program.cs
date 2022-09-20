// Задача 32: Напишите программу замена элементов массива:
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void InputArray(int[] array)// функция рандомного заполнения массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

int[] ChangeModule(int[] array)// метод (функция) по замене числа на отрицательное.Фукнция создает массив
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = (-1) * array[i];
    }
    return array;
}

int[] arr = new int[12];// новый массив
InputArray(arr); // запускает программу по заполнению массива
Console.WriteLine("Input Array: [" + string.Join(", ", arr) + "]");// выводит первый (вводный массив)
Console.WriteLine("Output Array: [" + string.Join(", ", ChangeModule(arr)) + "]");// выводит массив измененный методом
