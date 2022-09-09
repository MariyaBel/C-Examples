// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4-> 24
//5-> 120


Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
int res = 1;

for (int i = 1; i <= n; i++)
{
    res *= i;//res = res * i;
}

Console.WriteLine(res);


// Решение через while (начиная со строки 10)

// while (i <= n)
// {
//     res *= i;
//     i++;
// }
// Console.WriteLine(res);

