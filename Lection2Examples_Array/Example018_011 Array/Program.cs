void FillArray(int[] collection)// метод (функция) заполнения массива (коллекция)
{
    int length = collection.Length;// длина массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);//заполнения элемента массива случаным числом
        index++;//index=index+1
    }
}

void PrintArray(int[] col)// метод (функция) по выводу массива в консоль
{
    int count = col.Length;// длина массива col
    int position = 0;// index=0
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)// Метод Индекс в массиве (массив "collection", ищем в нем "find")
{
    int count = collection.Length;
    int index = 0;// индекс для перебора массива
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;// оператор который останавливает программу как только найдет первый find
            //без  break программа будет выводить номер последнего элемента с таким значением
        }
        index++;
    }
    return position;
}

int[] array = new int[10];//создали массив в 10 чисел

FillArray(array);//заполнение
PrintArray(array);// вывод
Console.WriteLine();

int numberofelement = IndexOf(array, 5);// запуск функции
Console.WriteLine(numberofelement);