// Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да


Console.Clear();
void InputNumbers()
{
    Console.WriteLine("Input number");
    int n = Convert.ToInt32(Console.ReadLine());
    
  
    if ((n % 7 == 0)&&(n % 4 == 0))
        Console.WriteLine("yes the number is a mutiple of 7 and 4");
    else
        Console.WriteLine("no the number is not a multiple of 7 and 4");
}

InputNumbers();
