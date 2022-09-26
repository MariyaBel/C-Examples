// Cобрать строку с числами от а до b, а< b

// string NumbersFor(int a, int b)// метод через оператор for
// {
//     string result = String.Empty;
//     for (int i = a; i <= b; i++)
//     {
//         result += $"{i} ";// result = result+$"{i}"
//     }
//     return result;
// }

// Console.WriteLine(NumbersFor(1, 10));// 1 2 3 4 5 6 7 8 9 10

// Решение через рекурсию

string NumbersRec(int a, int b)//функция с рекурсией
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
else return String.Empty;// выход из рекурсии
}

Console.WriteLine(NumbersRec(1, 10));// 1 2 3 4 5 6 7 8 9 10