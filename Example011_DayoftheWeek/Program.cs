Console.Write("Input number of the day between 1 and 7: ");
int n = Convert.ToInt32(Console.ReadLine());//Перевод строки в число
while (n<1||n>7)
{
    Console.Write("Are you stupid? Please repeat. Print a number between 1 and 7: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1)
    Console.WriteLine("Monday");
if (n == 2)
    Console.WriteLine("Tuesday");
if (n == 3)
    Console.WriteLine("Wednesday");
if (n == 4)
    Console.WriteLine("Thursday");
if (n == 5)
    Console.WriteLine("Friday");
if (n == 6)
    Console.WriteLine("Saturday");
if (n == 7)
    Console.WriteLine("Sunday");


