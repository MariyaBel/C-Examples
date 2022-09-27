// Обход дерева/  разбор арифм выражения

string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };// задали массив
//                 0    1   2     3     4    5   6    7     8    9    10   11
void InOrderTraversal(int i = 1)
{
    if (i < tree.Length)
    {
        int left = 2 * i;// задаем левую часть дерева
        int right = 2 * i + 1;// правая часть дерева
        if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
        // если лев/прав часть не выходят за пределы и значение не пустое, то обходим часть
        if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
        Console.WriteLine(tree[i]);// Вывод значения массива на позиции i
    }
}

InOrderTraversal();

