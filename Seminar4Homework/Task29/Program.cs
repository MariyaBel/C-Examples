// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

//Массив вводится в коде и выводится на экран
// int[] array = { 9, 4, 0, 77678, 0, 0, 0, 5 };
// Console.WriteLine ("[" + string.Join(", ", array) + "]");// функция string.Join объединяет эл-ты через ","



//Массив вводится пользователем и выводится на экран
int[] array = new int[8];// массив из 8 элементов
Console.WriteLine ("Input elements of array: ");
for (int i = 0; i < 8; i++)
    array[i] = Convert.ToInt32(Console.ReadLine());//заполнение массива пользователем

Console.WriteLine("[" + string.Join(", ", array) + "]");// 