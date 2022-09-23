// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

void InputMatrix(int[,] matrix)// ввод рандомного массива чисел
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-100, 100);
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

void MultiplyMatrix(int[,] firstmatrix, int[,] secondmatrix)// произведение матриц
{

    int[,] ResultMatrix = new int[firstmatrix.GetLength(0), firstmatrix.GetLength(1)];
    for (int i = 0; i < firstmatrix.GetLength(0); i++)
    {
        for (int j = 0; j < firstmatrix.GetLength(1); j++)
        {
            ResultMatrix[i, j] = firstmatrix[i, j] * secondmatrix[i, j];
            Console.Write(ResultMatrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] firstmatrix = new int[n, m];
InputMatrix(firstmatrix);
PrintMatrix(firstmatrix);
int[,] secondmatrix = new int[n, m];
InputMatrix(secondmatrix);
PrintMatrix(secondmatrix);
Console.WriteLine();
MultiplyMatrix(firstmatrix, secondmatrix);
