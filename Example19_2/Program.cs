//Напишите программу, 
//которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.WriteLine("Input coordinates X");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinates Y");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
    Console.WriteLine("I");
if (x < 0 && y > 0)
    Console.WriteLine("II");
if (x < 0 && y < 0)
    Console.WriteLine("III");
if (x > 0 && y < 0)
    Console.WriteLine("IV");
