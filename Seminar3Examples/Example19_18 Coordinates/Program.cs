// Задача 18: Напишите программу, которая по заданному номеру четверти,
 // показывает диапазон возможных координат точек в этой четверти 
 //(x и y).


Console.Clear();
Console.WriteLine("Input number of quater of coordinates between 1 and 4");
int x = Convert.ToInt32(Console.ReadLine());

while (x < 1 || x > 4)
    x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
    Console.WriteLine("X+ Y+");
if (x == 2)
    Console.WriteLine("X- Y+");
if (x == 3)
    Console.WriteLine("X- Y-");
if (x == 4)
    Console.WriteLine("X+ Y-");


// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// while (n < 1 || n > 4)
//     n = Convert.ToInt32(Console.ReadLine());

// if (n == 1)
//     Console.WriteLine("x > 0 and y > 0");
// if (n == 2)
//     Console.WriteLine("x < 0 and y > 0");
// if (n == 3)
//     Console.WriteLine("x < 0 and y < 0");
// if (n == 4)
//     Console.WriteLine("x > 0 and y < 0");
