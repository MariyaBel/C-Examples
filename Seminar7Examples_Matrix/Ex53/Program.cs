// Программа, которая определяет похожи ли массивы. 
// Массивы похожи, если если второй массив состоит из тех же чисел + любые повторения этих чисел 
// (т.е. совпадает алфавит массива) - то массивы похожи - yes
// Массивы не похожи, если во 2м массиве есть элементы другого алфавита - no

Console.Clear();

Console.WriteLine("Input number of elements in the first array: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arrayFirst = new int[n];
Console.WriteLine("Input elements in the first array: ");
for (int i = 0; i < n; i++)
    arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of elements in the second array: ");
int m = Convert.ToInt32(Console.ReadLine());
// int[] arraySecond = new int[n];// не создаем массив, а просто вводим подряд числа и сравниваем
bool flag = true;// поставили флаг на true
Console.WriteLine("Input elements in the second array: ");
for (int i = 0; i < m; i++)// начали ввод второго массива
{
    int k = 0;// вводим счетчик элементов, которые совпадают 
    int x = Convert.ToInt32(Console.ReadLine());
    
    for (int j = 0; j < n; j++)// цикл для проверки элементов 1го массива после ввода каждого эл-та второго
    {
        if (arrayFirst[j] == x) // сравниваем элементы первого массива с одним элементом второго
        {
            k++;
        }
    }
    if (k < 1)
        flag = false;// если элементы не совпадают, ставим флаг на ложь
}
if (flag)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");


// Пешение без bool 

//Console.Clear();

// int n = Convert.ToInt32(Console.ReadLine());
// int[] arrayFirst = new int[n];
// for (int i = 0; i < n; i++)
//     arrayFirst[i] = Convert.ToInt32(Console.ReadLine());

// int m = Convert.ToInt32(Console.ReadLine());
// // int[] arraySecond = new int[n];
// int flag = 1;
// for (int i = 0; i < m; i++)
// {
//     int k = 0;
//     int x = Convert.ToInt32(Console.ReadLine());
//     for (int j = 0; j < n; j++)
//     {
//         if (arrayFirst[j] == x)
//         {
//             k++;
//         }
//     }
//     if (k < 1)
//         flag == 0;

// }
// if (flag == 1)
//     Console.WriteLine("YES");
// else
//     Console.WriteLine("NO");

