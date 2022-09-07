// Найти период самой длинной оттепели (темп >0).
// ввод: 1 стр - N – общее количество рассматриваемых дней (1 ≤ N ≤ 100). 
// 2 стр - через пробел располагается N целых чисел, разделенных пробелами (среднесут темп). 
// Температуры – целые числа и лежат в диапазоне от –50 до 50.
// вывод: одно число – длину самой продолжительной оттепели (max последовательных дней >0).
// Решать циклом, без массива

Console.Clear();
Console.WriteLine("Input number of days in a period (from 1 to 100): ");
int n = Convert.ToInt32(Console.ReadLine());

int plusperiod = 0;// длительность периода оттепели
int plusperiodmax = 0;// длительность макс периода оттепели

Console.WriteLine("Input temperature (from -50 to 50 C) for each day: ");//строка до цикла,чтобы не повторять запрос
int t = Convert.ToInt32(Console.ReadLine());// температура 1го дня общего периода

// строки 20-24 проверяют попадает ли 1 день в период оттепели.
// если строки 15-16 ввести в цикл то строки 20-24 не нужны 
if (t > 0)
{
    plusperiod = 1;
    plusperiodmax = 1;
}
// цикл (cчетчик), начиная со второго дня общего периода
for (int i=1; i<n; i++)
{
    t = Convert.ToInt32(Console.ReadLine());
    if (t > 0)
    {
        plusperiod++;
        if (plusperiod > plusperiodmax) plusperiodmax = plusperiod; 
    }
    else plusperiod = 0;
}

Console.WriteLine("Max plusperiod is: " + plusperiodmax);