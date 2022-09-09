// Программа принимает на ввод число и выдает количество цифр в числе

Console.WriteLine("Input number:");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;// cчетчик цифр
while(n > 0)
{
    n /= 10;// n=n/10 делим число на 10 (уменьшаем цифры )
    count++;//увеличиваем счетчик
}
Console.WriteLine(count);
