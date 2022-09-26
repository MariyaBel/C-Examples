// Вычислить а в степени n

//Через цикл
// int PowerFor(int a, int n)
// {
//     int result=1;
//     for (int i=1;i<=n;i++) result*=a; //result=result*a
// return result;
// }
// Console.WriteLine(PowerFor(2,10));//1024

//Через факториал

// int PowerRec(int a, int n)
// {
// //а^n =a * a^(n-1)
// if (n==0) return 1;
// else return PowerRec(a,n-1)*a;
// }
// Console.WriteLine(PowerRec(2,10));//1024

// Через формулу
int PowerRecMath(int a, int n)
{
    if (n==0) return 1;
    else if (n%2==0) return PowerRecMath (a*a,n/2);// для четной степени: 2^28=(2^14)^2=(([2^7])^2)^2=([(2^3)^2*2^1]^2)^2)  
    else return PowerRecMath (a, n-1)*a;
}
Console.WriteLine(PowerRecMath(2,10));//1024