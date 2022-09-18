// Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.


void PrintArray(int[,] matr)// функция по рандомному заполнению и выводу двумерного массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 101);// заполняет числами [1;10)
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void HorizontalTransport(int[,] matr)
{
    int[,] htmatr = new int[matr.GetLength(0), matr.GetLength(1)];// можно ли сделать без создания нового массива? 

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i <= (matr.GetLength(0) / 2)) htmatr[i, j] = matr[matr.GetLength(0) - 1 - i, j];
            if (i > (matr.GetLength(0) / 2)) htmatr[i, j] = matr[matr.GetLength(0) - 1 - i, j];

            Console.Write($"{htmatr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//Можно ли сделать замену эл-тов первой матрицы без нового массива? 
// если вместо строк 22-29 + без стр. 19     записать 4 строки?
// 
//   int temp = matr[i, j];// 
// matr[i, j] = matr[matr.GetLength(0) - 1 - i, j];
// matr[matr.GetLength(0) - 1 - i, j] = temp;
// Console.Write($"{matr[i, j]} ");
// 
// то программа меняет только верхнюю половину таблицы (n/2 строк). Последние n/2 - остаются как были


Console.Write("Input number of rows in a matrix: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns in a matrix: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[n, m];
PrintArray(matrix);
Console.WriteLine();
HorizontalTransport(matrix);


