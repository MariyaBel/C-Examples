// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Input first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int b = Convert.ToInt32(Console.ReadLine());
int res=a;// можно int res=1
for (int i = 1; i < b; i++) // если int res= 1 то for (int i=0; i<b, i++)
{
    res = res*a;
}

Console.Write(res);