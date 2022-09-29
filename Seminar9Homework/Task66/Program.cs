// Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int n, int m)
{
    if (n == m) return m;
    else return n+SumNumbers(n-1,m);
}

Console.Write("Input first number (M): ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number (N). N>M : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumbers(n, m));
