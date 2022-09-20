//string[,] table = new string[2, 5];// задали новый двумерный массив название table
// String.Empty   - разделяет строки
// Элементы массива:
// table [0,0]    table [0,1]   ... table [0,4] (это последний, т.к. счет начинаеся с 0)
// table [1.0]    table [1,1] ...   table [1,4]


// table[1, 2] = "word";// положили в эту ячейку "word"

// for (int rows = 0; rows < 2; rows++)// rows - имя переменной-счетчика, можно заменить на i
// {
//     for (int columns = 0; columns< 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


void PrintArray(int[,] matr)// функция по выводу двумерного массива на экран
{
    for (int i = 0; i < matr.GetLength(0); i++)// GetLength(0) = 1е число в new int (строки)
    {
        for (int j = 0; j < matr.GetLength(1); j++)// длина цикла = GetLength+1 то есть 4 (столбцы)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

//проверка работоспособности фукнции 
//int[,] matrix = new int[3, 4];// задали массив
// PrintArray(matrix);// вызвали фукнцию распечатать



void FillArray(int[,] matr)// метод по заполнению массива
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);// заполняет числами [1;10)
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[3, 4];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
