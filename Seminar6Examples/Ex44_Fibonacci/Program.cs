// Не используя рекурсию, выведите первые
// N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
Console.WriteLine("Input the N number in Fibonacci row: ");
int n = Convert.ToInt32(Console.ReadLine());
int x, a0 = 0, a1 = 1; // вводятся 3 переменные/ x = результат сложения 2х переменных
for (int i = 0; i < n; i++)
{
    Console.Write(a0 + " ");
    x = a0 + a1;
    a0 = a1;
    a1 = x;
}

// Через массив

// Console.Clear();
// Console.WriteLine("Input the N number in Fibonacci row: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// array[0] = 0;
// array[1] = 1;
// for (int i = 1; i < n - 1; i++)
// {
//     array[i + 1] = array[i] + array[i - 1];
// }
// Console.WriteLine("[" + string.Join(", ", array) + "]");