﻿//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
//4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
//2 -> " -2, -1, 0, 1, 2"
// task 5

Console.Write("Input number: ");

int n = Convert.ToInt32(Console.ReadLine());

//решение 1
//for (int i = (-1) * n; i <= n; i++)// решение через оператор for
//Console.Write(i + " ");// запись числа с пробелом

//решение 2
int i = (-1) * n;// перевод числа в его же со знаком -
while (i <= n)
{
    Console.Write(i);// вывод числа
        while (i<n) // миницикл ставит запятую после числа
        {
        Console.Write(", ");
        break;
        }
    i++;
}
