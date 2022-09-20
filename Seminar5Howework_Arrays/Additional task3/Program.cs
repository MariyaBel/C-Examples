//Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) 
//на |K| элементов вправо, если K – положительное и влево, если отрицательное.
//Input:
//5  
//5 3 7 4 6                                    4 3 1      
//3                      -3
//output: 7 4 6 5 3       4 6 5 3 7 

//Решение через формулу

Console.Clear();

Console.WriteLine("Input number of elements in the array: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arrayFirst = new int[n];
int[] arrayResult = new int[n];

for (int i = 0; i < arrayFirst.Length; i++)
    arrayFirst[i] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[" + string.Join(", ", arrayFirst) + "]");

Console.WriteLine("Input K - the number to shift the array^ ");
int k = Convert.ToInt32(Console.ReadLine());
k = k % n;// сокращаем K т.к. сдвиг на K + n  = cдвиг на K

if (k > 0)
{
    for (int i = 0; i < k; i++)
        arrayResult[i] = arrayFirst[arrayFirst.Length - k + i];
    
    for (int i = 0; i < n - k; i++)
        arrayResult[k + i] = arrayFirst[i];
}

else
{
    k = (-1) * k;
    for (int i = 0; i < k; i++)
        arrayResult[arrayFirst.Length - k + i] = arrayFirst[i];
    
    for (int i = 0; i < n - k; i++)
        arrayResult[i] = arrayFirst[k + i];
}

Console.WriteLine("[" + string.Join(", ", arrayResult) + "]");

