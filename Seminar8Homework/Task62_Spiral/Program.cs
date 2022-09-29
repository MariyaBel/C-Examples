// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


Console.Clear();

int[,] SpiralMatrix(int[,] spiral, int row, int col, int orderNumber)// аргументы: массив, точка старта (строка, столбец), начальный элемент
{
    spiral[row, col] = orderNumber;

    if (row - 1 < 0 || spiral[row - 1, col] != 0)// формула для 1 строки: направо до правого верхнего угла
    {
        if (col + 1 < spiral.GetLength(1) && spiral[row, col + 1] == 0)
            return SpiralMatrix(spiral, row, ++col, ++orderNumber);
    }

    if (row + 1 < spiral.GetLength(0) && spiral[row + 1, col] == 0)// Поворот и вниз до нижнего угла
        return SpiralMatrix(spiral, ++row, col, ++orderNumber);

    if (col > 0 && spiral[row, col - 1] == 0)// Налево до левого нижнего угла
        return SpiralMatrix(spiral, row, --col, ++orderNumber);

    if (row > 0 && spiral[row - 1, col] == 0)// Вверх до левого верхнего угла
        return SpiralMatrix(spiral, --row, col, ++orderNumber);

    return spiral;
}

void PrintMatrix(int[,] matr)
{
    Console.WriteLine();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            Console.Write(matr[i, j] + "\t");
        Console.WriteLine();
    }
}

Console.WriteLine("Input matrix size: rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input matrix size: columns: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
PrintMatrix(SpiralMatrix(spiral: matrix, row: 0, col: 0, orderNumber: 1));