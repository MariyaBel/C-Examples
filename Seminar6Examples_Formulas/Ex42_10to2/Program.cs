// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 2 -  10, 45 -> 101101

Console.Clear();
Console.WriteLine("Input number: ");
int n = Convert.ToInt32(Console.ReadLine());

string result = "";// вводится строковая переменная результат

while (n > 0)
{
    int x = n % 2;
    result = Convert.ToString(x) + result;// сначала записывает последний остаток от деления, потом предпоследний и т.д.
    n = n / 2;
}
Console.WriteLine(result);


// Решение Через рекурсию

// Console.Clear();
// string f(int n)
// {
//     if (n == 0 || n == 1)
//         return Convert.ToString(n);// 0 в двоичной = 0, 1 = 1 
//     return f(n / 2) + Convert.ToString(n % 2);// для остальных числе правило: остаток от деления на 2 
// }
// Console.WriteLine(f(11));