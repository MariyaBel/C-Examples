// Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98


int GenerateRandomNumbers()// функция для вывода случайного числа от 100 до 999 включительно
{
    int n = new Random().Next(100, 1000);
    return n;
}

void CompraiseNumbers()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine(n);
    int a =n/100;// находим первую цифру (сотни)
    int b = n%10;// находим третью цифру
   
    Console.WriteLine(a*10+b);
    
}

CompraiseNumbers();

// Вариант 2 - склеить как текст 

// int GenerateRandomNumber()
// {
//     int n = new Random().Next(100, 1000);
//     return n;
// }

// void CompraiseNumbers()
// {
//     int n = GenerateRandomNumber();
//     Console.WriteLine(n);
//     Console.Write(Convert.ToString(n)[0]);
//     Console.Write(Convert.ToString(n)[2]);
// } 

// CompraiseNumbers();
