// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void InputNumber()
{
    Console.WriteLine("Input 3 digit number");
    int n = Convert.ToInt32(Console.ReadLine());

    int a = n / 10;// находим сколько десятков
    int b = a % 10; // находим остаток от деления а на 10 (2я цифра n)


    Console.WriteLine(b);

}

InputNumber();