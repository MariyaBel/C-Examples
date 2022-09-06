/ Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
int n = Convert.ToInt32(Console.ReadLine());
int max_f = n;
int max_s = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max_f)
    {
        max_s = max_f;
        max_f = n;
    }
    else if (n > max_s)
    {
        max_s = n;
    }
}
Console.WriteLine(max_s);
17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
