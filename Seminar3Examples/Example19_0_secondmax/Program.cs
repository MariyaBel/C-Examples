Console.Clear();
Console.WriteLine ("Input as many numbers as you wish, the last one shall be 0: ");
int n = Convert.ToInt32(Console.ReadLine());
int max_f = n;// Первый максимум
int max_s = -1;// Второй максимум
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max_f)// Сравнение с первым максимумом
    {
        max_s = max_f;
        max_f = n;
    }
    else if (n > max_s)// Cравнение со вторым максимумом
    {
        max_s = n;
    }
}
Console.WriteLine("Second max =" + max_s);