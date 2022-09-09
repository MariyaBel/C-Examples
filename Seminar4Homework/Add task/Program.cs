// Кусты черники высажены по окружности, у каждого куста есть ровно два соседних. Всего на грядке растет N кустов.
// Эти кусты обладают разной урожайностью: на i-ом кусте выросло ai ягод.
// Собирающий модуль за один заход, находясь перед i-ом кустом, собирает ягоды с этого куста и с двух соседних с ним.
// Напишите программу для нахождения max числа ягод, которое может собрать за один заход модуль, находясь перед i-ом кустом
// 4    1 2 3 4      -- > 9 
//3     1 2  3       --> 6

Console.WriteLine("Input number of berry bushes: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n]; // динамический массив, т.е. длину задает пользователь

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 11);

Console.WriteLine("[" + string.Join(", ", array) + "]");

int sum = 0;
int summax = 0;

for (int i = 0; i < n; i++)
{
    if (i==0) sum=array[i]+array[i+1]+array[n-1];
    else if (i==n-1) sum=array[i]+array[0]+array[n-2];
    else sum = array[i] + array[i + 1] + array[i - 1];

    if (summax < sum) summax = sum;
}
Console.WriteLine(summax);