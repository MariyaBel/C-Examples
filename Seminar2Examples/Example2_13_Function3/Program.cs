// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
void InputNumbers()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(n + " " + m);
    if (n % m == 0)
        Console.WriteLine("yes");
    else
        Console.WriteLine(n % m);
}

InputNumbers();


