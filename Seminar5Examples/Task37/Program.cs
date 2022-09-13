// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 9 (средний элемент умножается на себя)
// [6 7 3 6] -> 36 21

Console.Clear();
void InputArray(int[] array)// функция по созданию массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void Pairresult(int[] array)//  фукнция поиска пары
{
    int lenArray;// переменная = длина массива

    if (array.Length % 2 == 0)// если кол-во элементов в массиве четное 
        lenArray = array.Length / 2;
    else
        lenArray = array.Length / 2 + 1;// если нечетное + 1 (добавляем серединный элемент)

    int[] ResultArray = new int[lenArray];// cоздаем новый массив (результат произведений)

    for (int i = 0; i < lenArray; i++)// цикл до середины масива
    {
       ResultArray[i] = array[i] * array[array.Length - i - 1];//умножение элемента на "парный с конца"
    }
    Console.WriteLine("Final array of multiples: [" + string.Join(", ", ResultArray) + "]");//вывод массива (внутри фукнции)
}

Console.WriteLine("Input number of elements in array between 1 and 10: ");
int a=Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];// задали массив
InputArray(array);// заполнрили массив
Console.WriteLine("Input array: [" + string.Join(", ", array) + "]");// Печать исходного массива
Pairresult(array);// Печать массива произведений пар


