// Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деление.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.Clear();
void InputNumbers()
{
    Console.WriteLine("Input number");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input number");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(n + " " + m);
    if (n % m == 0)
        Console.WriteLine("yes the first number is a mutiple");
    else
        Console.WriteLine("no the first number is not a multiple, the remainer is " + n % m);
}

InputNumbers();
