// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Пример
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ввод:  строка 2  столбец 1
// Вывод: 4

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

int FindinMatrix(int[,] matrix)// поиск значения элемента матрицы по индексам. Можно сделать void
{
    Console.WriteLine("Input number of row of the element: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number of column of the element: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int element=0;

    if (a >= matrix.GetLength(0) || b >= matrix.GetLength(1)) 
    {
       Console.WriteLine("There's no emement with theese coordinates");
       return element;
    }   
      
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            if ((i == a) && (j == b))
            {
                element=matrix[i, j];
                return element;
            }

        Console.WriteLine();
    }
return element;
}

Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine(FindinMatrix(matrix));


