// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void InputDayoftheWeek()
{
    Console.WriteLine("Input number of the day of the week");
    int n = Convert.ToInt32(Console.ReadLine());

  while ((n<1)||(n>7))
  {
    Console.WriteLine("Wrong number.Please input number of the day between 1 and 7");
    n = Convert.ToInt32(Console.ReadLine());
  }

    if ((n==6)||(n==7)) Console.WriteLine("Yes, it's a weekend");
    else Console.WriteLine("No, it's not a weekend");

}

InputDayoftheWeek();