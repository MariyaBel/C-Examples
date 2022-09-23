// Посчитать сколько раз в массиве встречается каждый элемент

Console.Clear();


void InputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int x = new Random().Next(1, 10);
            matrix[i, j] = x;
            array[k] = x;
            k++;
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j] + " \t");
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[] array)
{
    int[] help_array = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int count = 1;
        bool flag = true;
        foreach (int el in help_array)
        {
            if (array[i] == el)
                flag = false;
        }
        if (flag)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j] && i != j)
                {
                    count++;
                    help_array[i] = array[i];
                }

            }
            Console.WriteLine(array[i] + " can be found " + count + " times");
        }
    }
}

Console.Write("input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("input number of columns: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
int[] array = new int[n * m];// создаем одномерный массив, куда сложим весь двумерный. Проверять будем одномерный
InputMatrix(matrix, array);
PrintMatrix(matrix);
ReleaseMatrix(array);
