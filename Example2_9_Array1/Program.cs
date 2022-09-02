// Программа генерирует случайное двузначное число. 
// Сравнивает кол-во десятков и единиц в нем и выводит большее из них.

int GenerateRandomNumbers()// функция для вывода случайного числа от 10 до 99 включительно
{
    int n = new Random().Next(10, 100);
    return n;
}

void CompraiseNumbers()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine(n);
    int a = n / 10;// находим число десятков
    int b = n % 10;// находим число единиц
    if (a > b)
        Console.WriteLine(a);
    else if (b < a)
        Console.WriteLine(b);
    else
        Console.WriteLine("=");
}

CompraiseNumbers();

