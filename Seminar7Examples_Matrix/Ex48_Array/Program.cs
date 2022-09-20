// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Clear();

void InputMatrix(int[,] matrix)// ввод массива [i+]
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = i+j;
    }
}

void PrintMatrix(int[,] matrix)// вывод матрицы на экран
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
