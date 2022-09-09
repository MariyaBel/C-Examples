// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Input a 5digit number");
int x = Convert.ToInt32(Console.ReadLine());

if ((x/10000)==(x%10)&&(((x/1000)%10)==(x/10)%10)) Console.WriteLine ("yes,it's a palyndrome");
else Console.WriteLine ("No,it's not a palyndrome");