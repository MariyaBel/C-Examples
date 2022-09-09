// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while(n > 0)
{
    sum = sum + (n % 10);// сумма остатков от деления на 10
    n = n / 10;
}
Console.WriteLine("The sum of digits is: " + sum);