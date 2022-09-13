// Кусты черники высажены по окружности, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
// Эти кусты обладают разной урожайностью: на i-ом кусте выросло ai ягод.
// Собирающий модуль за один заход, находясь перед i-ом кустом, собирает ягоды с этого куста и с двух соседних с ним.
// Напишите программу для нахождения max числа ягод, которое может собрать за один заход модуль, находясь перед i-ом кустом
// 4    1 2 3 4      -- > 9 
//3     1 2  3       --> 6

// Console.WriteLine("Input number of berry bushes: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n]; // динамический массив, т.е. длину задает пользователь

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 11);

// Console.WriteLine("[" + string.Join(", ", array) + "]");

// int sum = 0;
// int summax = 0;

// for (int i = 0; i < n; i++)
// {
//     if (i == 0) sum = array[i] + array[i + 1] + array[n - 1];
//     else if (i == n - 1) sum = array[i] + array[0] + array[n - 2];
//     else sum = array[i] + array[i + 1] + array[i - 1];

//     if (summax < sum) summax = sum;
// }
// Console.WriteLine(summax);


// Решение учителя
// Console.Clear();
// Console.Write("Input number of bushes: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(1, 10);

// Console.WriteLine("Numbers of berries on the bushes, array: [" + string.Join(", ", array) + "]");

// int summa_last = array[array.Length - 1] + array[0] + array[1];
// int summa_first = array[0] + array[array.Length - 1] + array[array.Length - 2];
// if (summa_first > summa_last)
//     summa_last = summa_first;
// for (int i = 1; i < array.Length - 1; i++)
//  {
//    int summa = array[i - 1] + array[i] + array[i + 1];
//     if (summa_last < summa)
//        summa_last = summa;
//  }
//  Console.WriteLine(summa_last);


//Решение через 2 массива

Console.Clear();
Console.Write("Input number of bushes: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];// создание 1 массива
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 10);// заполнение массива

Console.WriteLine("Numbers of berries on the bushes, array: [" + string.Join(", ", array) + "]");// вывод 1го массива

int[] result_array = new int[n]; // создание 2го массива (сумм)
for (int i = 1; i< array.Length - 1; i++)
{
    result_array[i - 1] = array[i - 1] + array[i] + array[i + 1];
}
result_array[result_array.Length - 2] = array[array.Length - 1] + array[0] + array[1];
result_array[result_array.Length - 1] = array[0] + array[array.Length - 1] + array[array.Length - 2];

Console.WriteLine("Sums of berries from 3 neighbouring bushes: [" + string.Join(",", result_array) + "]");

int max_number = result_array[0];
for (int i = 1; i< result_array.Length; i++)
{
    if (max_number<result_array[i])
        max_number = result_array[i];
}
Console.WriteLine("max number is: " + max_number);

