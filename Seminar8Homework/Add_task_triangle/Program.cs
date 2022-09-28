// Задача 61: Вывести первые N строк треугольника Паскаля. 
//Сделать вывод в виде равнобедренного треугольника

Console.WriteLine ("Input the number of elements in the bottom layer of triangle: ");
int n = Convert.ToInt32(Console.ReadLine());
int i, c;

float factorial(int n)// float = double   функция возврата факториала числа x! (от 1 до n)
{
float i, x = 1;
for (i = 1; i <= n; i++)
x *= i;
return x;
}

for (i = 0; i < n; i++)
{
for (c = 0; c <= (n - i); c++)// цикл по расстановке пробелов в строке (n-i)
Console.Write(" ");
for (c = 0; c <= i; c++)// цикл вычисляющий каждый последующий элемент строки в треугольнике
{
Console.Write(" ");
Console.Write(factorial(i) / (factorial(c) * factorial(i - c)));
}
Console.WriteLine();// строки отступа
Console.WriteLine();// строки отступа
}
Console.ReadLine();// строка которая "подвешивает терминал" до ввода любого символа