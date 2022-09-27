// Время работы программы: циклы и Фибоначчи

decimal fRec = 0;// Кол-во итераций рекурсии в методе
decimal fIte = 0;// кол-во итераций метода цикла

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1; decimal f1 = 1;
}


Console.ReadLine();
DateTime dt = DateTime.Now;// засекли время начала подсчета
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte={fIte.ToString("### ### ###"),-15};
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

Console.WriteLine();
Console.ReadLine();
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n})={FibonacciRecursion(n)} {{FibonacciRecursion(n)} fRec={fRec.ToString("### ### ###""),-15}}");
    fREc = 0;
}

