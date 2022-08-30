// В ответ на введенное число вывести соответствующий ему день недели

Console.Write("Print number between 1 and 7: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 1 || n > 7)
{
   Console.WriteLine("Wrong number.Please print number between 1 and 7: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 1) Console.WriteLine("Monday");
if (n == 2) Console.WriteLine("Tuesday");
if (n == 3) Console.WriteLine("Wednesday");
if (n == 4) Console.WriteLine("Thursday");
if (n == 5) Console.WriteLine("Friday");
if (n == 6) Console.WriteLine("Saturday");
if (n == 7) Console.WriteLine("Sunday");