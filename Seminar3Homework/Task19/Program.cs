// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Решение через формулу
Console.Clear();
Сonsole.WriteLine("Input a 5digit number");
int x = Convert.ToInt32(Console.ReadLine());

if ((x/10000)==(x%10)&&(((x/1000)%10)==(x/10)%10)) Console.WriteLine ("yes,it's a palyndrome");
// 12321: 12321/10000=1  12321 %10 =1    12321/1000= 12 %10 = 2      12321/10=1232 %10 =2
else Console.WriteLine ("No,it's not a palyndrome");

//Решение через строку

Console.WriteLine("Input a 5digit number:");
string n = Console.ReadLine();

if (((n)[0] == (n)[4]) && ((n)[1] == (n)[3])) Console.WriteLine("yes,it's a palyndrome");
else Console.WriteLine("No,it's not a palyndrome");