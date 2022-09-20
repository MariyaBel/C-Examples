// Программа которая считает сумму элементов по главной диагонали массива ([0;0]+[1;1]  и т.д.)

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

int ReleaseSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
                sum += matrix[i, j];
        }
    }

    return sum;
}


Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of elements: ");
int m = Convert.ToInt32(Console.ReadLine());
int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Sum of elements on diagonal: " + ReleaseSum(matrix));
