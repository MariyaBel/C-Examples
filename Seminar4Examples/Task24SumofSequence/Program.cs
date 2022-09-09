// // Программа принимает на ввод число и выдает сумму цифр от 1 до числа
// // 7   ->  28 (=1+2+3+4+5+6+7)
// //  4    - >  10   

// Решение через циклы:
// Console.Clear();
// Console.WriteLine("Input number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i=1; i<=n; i++)
// sum=sum+i;

// Console.WriteLine(sum);

//Решение через  прогрессию
Console.WriteLine("Input number: ");
double n=Convert.ToInt32(Console.ReadLine());
Console.Write((1+n)*n/2); // Формула суммы арифм. прогрессии Sum = ((A1+An)/2)*n   


