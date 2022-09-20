double Factorial(int n)
{
    if (n == 1) return 1;// 1!=1 , 0!=1
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(5));//1*2*3=6

for (int i=1;i<40;i++)
{
    Console.WriteLine(Factorial(i));
}