void FillArray(int[] collection)// метод (функция) заполнения массива (коллекция)
{
    int length = collection.Length;// длина массива
    int index = 0;
    while (index < length)
    {
        collection[index]=new Random().Next(1,10);//заполнения элемента массива случаным числом
        index++;//index=index+1
    }
}

void PrintArray(int[] col)// метод (функция) по выводу массива в консоль
{
    int count = col.Length;// длина массива col
    int position = 0;// index=0
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int[]array = new int[20];//создали массив в 20 чисел

FillArray(array);//заполнение
PrintArray(array);// вывод
