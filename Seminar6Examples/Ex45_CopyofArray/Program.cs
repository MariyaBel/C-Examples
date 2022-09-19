// Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

Console.Clear();

int[] array = {1, 2};
int[] array1 = new int[array.Length];// для копирования массива создаем новый 

for (int i = 0; i < array.Length; i++)// цикл для копирования
    array1[i] = array[i];
array1[0] = 10;// изменим число в копии

Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", array1));