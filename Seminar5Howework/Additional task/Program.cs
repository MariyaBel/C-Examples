//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
//на |K| элементов вправо, если K – положительное и влево, если отрицательное.
//Input:
//5  
//5 3 7 4 6                                    4 3 1      
//3                      -3
//output: 7 4 6 5 3       4 6 5 3 7 

//Решение через цикл (повторяется K раз), в теле цикла - сдвиг на 1 элемент вправо или влево, в зависимости от K (+-)

Console.Clear();
void InputArray(int[] array)// функция по созданию массива
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 11);
    Console.WriteLine("Input array: [" + string.Join(", ", array) + "]");
}

int [] ShiftArray(int[] array)
{
    Console.WriteLine("Input number to circularily shift the array: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a==0) 
    {
        Console.WriteLine("Final array: [" + string.Join(", ", array) + "]");
        return array;
    }

    int[] shifted_array = new int[array.Length]; // создание 2го массива (первый сдвиг)

    for (int shift = 0; shift <= Math.Abs(a) - 1; shift++)//цикл на число повторов = абс значению а (Math.Abs(a))
    {
        if (a > 0)// при выполнении условия сдвигаем все значения на 1 шаг вправо
        {
            int temp = array[array.Length - 1];// запоминаем последний элемент
            for (int j = 1; j <= array.Length - 1; j++)
                shifted_array[j] = array[j - 1];

            shifted_array[0] = temp;
        }
        else if (a < 0) // при невыполнении условия сдвигаем все значения на 1 шаг влево
        {
            int temp = array[0];// запоминаем нулевой элемент
            for (int j = 0; j <= array.Length - 2; j++)
                shifted_array[j] = array[j + 1];
            shifted_array[array.Length - 1] = array[0];
        }
        //Console.WriteLine("Shift done: [" + string.Join(", ", shifted_array) + "]");//вывод массива со сдвигом на 1 

        for (int l = 0; l <= array.Length - 1; l++)
            array[l] = shifted_array[l];
    }
    Console.WriteLine("Final array: [" + string.Join(", ", shifted_array) + "]");
    return array;
}

Console.WriteLine("Input number of elements in array between 1 and 10: ");// запрос ввода длины массива
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];// задали массив
InputArray(arr);
ShiftArray(arr);


