// // Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("How many numbers will you input? ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number and press Enter: ");

int[] arr = new int[n];
int count=0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if (arr[i]>0) count++;
}
Console.WriteLine(count+" numbers > 0");


