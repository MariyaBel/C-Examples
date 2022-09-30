// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AccermanRec(int n, int m)
{
    if (n==0) return m+1;
    else if ((n>0)&&(m==0)) return AccermanRec(n-1,1);
    else return AccermanRec(n-1,AccermanRec(n,m-1));
}

Console.WriteLine(AccermanRec(2,3));