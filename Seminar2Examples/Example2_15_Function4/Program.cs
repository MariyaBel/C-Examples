// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет



Console.Clear();
void InputNumbers()
{
    Console.WriteLine("Input first number");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input first number");
    int m = Convert.ToInt32(Console.ReadLine());
    
  
    if ((n / m == m)||(m / n == n))
        Console.WriteLine("yes, one is a square of another");
    else
        Console.WriteLine("no, one is not a square of another");
}

InputNumbers();



// вариант 2
// void Num()
// {
//     int n = Convert.ToInt32(Console.ReadLine());
//     int m = Convert.ToInt32(Console.ReadLine());
//     if (n * n == m || m * m == n)
//         Console.WriteLine("yes");
//     else
//         Console.WriteLine("no");
// }
// Num();

