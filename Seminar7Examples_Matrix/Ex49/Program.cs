// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

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

void ReleaseMatrix(int[,] matrix)// замена нечетных элементов на их квадраты
{
    int[,] ResultMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 1; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 1; j < matrix.GetLength(1); j+=2)
        
            matrix[i, j] = matrix[i, j] * matrix[i, j];
            Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
ReleaseMatrix(matrix);
PrintMatrix(matrix);



// void ReleaseMatrix(int[,] matrix)
// {
//     for (int i = 1; i < matrix.GetLength(0); i+=2)
//     {
//         for (int j = 1; j < matrix.GetLength(1); j+=2)
//             matrix[i, j] = matrix[i, j] * matrix[i, j];
//         Console.WriteLine();
//     }
// }


// Console.Write("Введите кол-во строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[, ] matrix = new int[n, m];
// InputMatrix(matrix);
// PrintMatrix(matrix);
// ReleaseMatrix(matrix);
// PrintMatrix(matrix);
