// Метод флажка

// break - ломать

bool flag = true;

// Найдите минимальный делитель числа
int n = Convert.ToInt32(Console.ReadLine());
int i = 2;
while (flag)
{
    if (n % i == 0)
    {
        Console.WriteLine(i);
        flag = false;
    }
    i++;
}

