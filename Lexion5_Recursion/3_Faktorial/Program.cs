// Факториал от n (n!)

//Решение через цикл

// int FactorialFor(int n)
// {
//     int result=1;
//     for (int i=1;i<=n;i++)result *=i;//result=result*i
//     return result;
// }
// Console.WriteLine(FactorialFor(10));//3628800

//Решение через рекурсию
int FactorialRec(int n)
{
    if (n==0) return 1;
    if (n==1) return 1;
    else return n*FactorialRec(n-1);
}
Console.WriteLine(FactorialRec(10));//3628800