// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// 1 вариант - Решение через деление на 100

void SelectSecondFigure()
{
    Console.WriteLine("Input int number");
    int n = Convert.ToInt32(Console.ReadLine());
     
     if (n<100) Console.WriteLine("There is no third figure in that number");
     else Console.Write(Convert.ToString(n)[2]);  
     
        
} 

SelectSecondFigure();

