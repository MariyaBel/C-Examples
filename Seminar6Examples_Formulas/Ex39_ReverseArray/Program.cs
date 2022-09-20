// Напишите программу, которая
// перевернёт одномерный массив (последний элемент
// будет на первом месте, а первый - на последнем и
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void Reverse(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int x = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = x;
    }
}

Console.Write("Input number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Reverse(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");