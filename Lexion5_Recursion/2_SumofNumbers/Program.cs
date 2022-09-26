// сумма чисел от 1 до N

// int SumFor(int n)// решение через цикл for
// {
//     int result=0;
//     for (int i=1;i<=n;i++) result +=i;
//     return result;
// }

// Console.WriteLine(SumFor(10));//запуск метода от 10  .   =55

//Решение через рекурсию

int SumRec(int n)
{
    if (n ==0) return 0;
    else return n + SumRec(n - 1);
}
Console.WriteLine(SumRec(10));//55
