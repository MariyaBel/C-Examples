// Найти период самой длинной оттепели (темп >0).
// ввод: 1 стр - N – общее количество рассматриваемых дней (1 ≤ N ≤ 100). 
// 2 стр - через пробел располагается N целых чисел, разделенных пробелами (среднесут темп). 
// Температуры – целые числа и лежат в диапазоне от –50 до 50.
// вывод: одно число – длину самой продолжительной оттепели (max последовательных дней >0).
// Решать циклом, без массива

Console.WriteLine("Input number of days in a period (from 1 to 100): ");
int n = Convert.ToInt32(Console.ReadLine());

int t=0;
int plusperiod = 0;// длительность периода оттепели
int plusperiodmax = 0;// длительность макс периода оттепели

Console.WriteLine("Input temperature (from -50 to 50 C) for each day: ");//строка до цикла,чтобы не повторять запрос

// цикл (cчетчик), начиная с первого дня общего периода
for (int i=0; i<n-1; i++)
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