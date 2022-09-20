// // Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

void InputArray(int[] array)// функция по заполнению массива (без вывода данных)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-9, 10);
}

string SearchNumber(int[] array, int number)// функция поиска числа и вывода да или нет
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
            return "yes";// вывод да, если условие выполняется + прекращение работы программы (return)
    }
    return "no";// вывод нет, если условие не выполнялось
}

int[] array = new int[12];//создание массива
InputArray(array);// запуск функции заполнения массива
Console.WriteLine("Array: [" + string.Join(", ", array) + "]");// вывод массива на экран
Console.Write("Input number to find: ");// введите число для поиска
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SearchNumber(array, n));// запуск фукнции поиск от созданного массива и числа



