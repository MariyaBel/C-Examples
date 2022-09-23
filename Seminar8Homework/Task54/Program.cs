// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();

void InputMatrix(int[,] matrix)// ввод рандомного массива
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-10, 11);
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

void ReleaseMatrix(int[,] matrix)// упорядочение строк по убыванию
{
    
    int[,] ResultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    int max=matrix[i,0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int k=1;
        for (int j = k; j < n; j++)
        matrix [i,0]=temp
        if (matrix [i,j]>max)
        {
            ResultMatrix[i;k]=matrix[i,j];
            k++;
        }

            ResultMatrix[i, j] = matrix[matrix.GetLength(0) - i - 1, j];
        Console.WriteLine();
    }
    PrintMatrix(ResultMatrix);
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);