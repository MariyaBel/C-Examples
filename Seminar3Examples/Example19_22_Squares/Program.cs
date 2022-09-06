// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Input number");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;

for (int i = 1; i <= n; i++)
{
res = i * i;
Console.Write(res + " ");
}

// Можно записать корочеConsole.Clear();
// int n = Convert.ToInt32(Console.RConsole.Clear();
// for (int i = 1; i <= n; i++)
//     Console.WriteLine(i + "^2 = " + i * i + " ");

