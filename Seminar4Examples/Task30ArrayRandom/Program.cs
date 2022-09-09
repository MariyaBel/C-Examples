// Задача 30: Наintпишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8];// статический массив из 8 элементов

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 2);//заполнение массива числами 0 и 1 (Next не включает 2е число)

Console.WriteLine("[" + string.Join(", ", array) + "]");// функция соединяет элементы массива б


//Динамический массив (пользователь задает длину массива) 
//Console.WriteLine("Input lenght of the array: );  
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n]; // динамический массив, т.е. длину задает пользователь

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 3);
//     // array[0] = 0/1;
//     // array[1] = 0/1;
//     // array[2] = 0/1;   

// Console.WriteLine("[" + string.Join(", ", array) + "]");
