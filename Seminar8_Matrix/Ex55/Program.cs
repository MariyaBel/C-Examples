// Заменить местами строки на столбцы. Если это невозможно - вывести сообщение

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

int[,] ReleaseMatrix(int[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)// берем столбец от i+1, а не от i - чтобы не было двойной замены
        {
            int x = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = x;
        }
    }
    return matrix;
}


Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n != m)
    Console.WriteLine("Change is not possible");
else
{
    int[,] matrix = new int[n, m];
    InputMatrix(matrix);
    PrintMatrix(matrix);
    PrintMatrix(ReleaseMatrix(matrix));
}

