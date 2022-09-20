int[] array = { 1, 2, 4, 4, 5, 4, 7, 8 }; // задали массив
int n = array.Length;   // n = длина массива

int find = 4; // присвоили переменной find значение

int index = 0;
while (index < n) 
{
    if (array[index] == find) 
    { 
        Console.WriteLine(index);
        break;// без этого оператора код будет выводить все элементы массива равные find
    }
    index++; //index=index+1
    
}


