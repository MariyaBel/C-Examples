//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
//на |K| элементов вправо, если K – положительное и влево, если отрицательное.
//Input:
//5  
//5 3 7 4 6                                    4 3 1      
//3                      -3
//output: 7 4 6 5 3       4 6 5 3 7 

//Решение через цикл (повторяется K раз), в теле цикла - сдвиг на 1 элемент вправо или влево, в зависимости от K (+-)


void InputArray(int[] array)// функция по созданию массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
    Console.WriteLine("Input array: [" + string.Join(", ", array) + "]");
}

int[] ShiftArray(int[] array)// функция по сдвигу массива
{
    Console.WriteLine("Input number to circularily shift the array: ");
    int k = Convert.ToInt32(Console.ReadLine());

    if (k == 0) return array;
    else
    {
        for (int i = 0; i < Math.Abs(k); i++)
        {
            if (k < 0)// сдвиг влево не работает!
            {
                int aLast = array[0];
                for (int j = 0; j <= array.Length - 2; j++)// эта строка не работает
                    array[j]=array[j+1];// эта строка не работает
                array[array.Length - 1] = aLast;
            }
            if (k > 0)
            {
                int aLast = array[array.Length - 1];
                for (int j = array.Length - 1; j >= 1; j--)
                    array[j] = array[j - 1];
                array[0] = aLast;
            }
        }
    }
    return array;
}

Console.Clear();
Console.WriteLine("Input number of elements in array between 1 and 10: ");// запрос ввода длины массива
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];// задали массив
InputArray(arr);// вывели массив
Console.WriteLine("Shifted array: [" + string.Join(", ", ShiftArray(arr)) + "]");

