// программа, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int PrintNumbers(int a, int b)
{
    if (b == 0) return 1;// если степень =0, то умножаем на 1
    return PrintNumbers(a, b - 1) * a;// функция от (а в степени b-1)*a 
}

Console.WriteLine(PrintNumbers(2, 5));
