// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Clear();

// void InputMatrix(int[,,] matrix)// ввод трехмерного массива заполненного неповторяющ числами от 10
// {
//     int n = 10;// значение в ячейке [0,0,0]
//     for (int z = 0; z < matrix.GetLength(2); z++)
//     {
//         for (int x = 0; x < matrix.GetLength(0); x++)
//         {

//             for (int y = 0; y < matrix.GetLength(1); y++)
//                 matrix[x, y, z] = n++;
//         }
//     }
// }

// void PrintMatrix(int[,,] matrix)// вывод тремерной матрицы на экран
// {
//     Console.WriteLine();
//     for (int z = 0; z < matrix.GetLength(2); z++)
//     {
//         for (int x = 0; x < matrix.GetLength(0); x++)
//         {
//             for (int y = 0; y < matrix.GetLength(1); y++)
//                 Console.Write(matrix[x, y, z] + " \t");
//             Console.WriteLine();
//         }
//     }
// }


// Console.Write("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of columns: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of levels: ");
// int o = Convert.ToInt32(Console.ReadLine());
// int[,,] matrix = new int[n, m, o];
// InputMatrix(matrix);
// PrintMatrix(matrix);



// Ввод и заполнение массива
Console.Write("Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of levels: ");
int o = Convert.ToInt32(Console.ReadLine());
int[,,] matrix = new int[n, m, o];
int k = 10;
for (int x = 0; x < matrix.GetLength(0); x++)
{
    for (int y = 0; y < matrix.GetLength(1); y++)
    {
        for (int z = 0; z < matrix.GetLength(2); z++)
        {
            matrix[x, y, z] = k++;
            Console.WriteLine($"{matrix[x, y, z]} {x}, {y} ,{z}");// вывод каждого эл-та с новой строки
        }
    }
}