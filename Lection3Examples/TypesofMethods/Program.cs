//Виды функций (методов)

//Метод 1. Ничего не принимает, не возвращает
void Method1()
{
    Console.WriteLine("Surname,name");// метод, выводящий подпись
}
Method1("Beliakova Maria);

// Метод 2. Принимает, но не возвращает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2(msg: "Whatever you write");// вызов Method2

//Метод 2.1.
void Method21(string msg, int count)
{
    int i = 0;
    while (i<count)
    {
    Console.WriteLine(msg);
    i++;
    }
}
Method21("Text", 4);
// если используются именованные аргументы, их можно писать не по порядку
//Method21 (count: 4, msg: "Text")

//Метод 3
int Method3()
{
    return DateTime.Now.Year;
}

int year =Method3();
Console.WriteLine(year);


// Метод4
string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;// выходные данные - пустая строка
    
    while (i<count)
        {
            result = result + text;
            i++;
        }
        return result;
}
string res = Method4(10, "as;dlgk");
Console.WriteLine (res);

//// Метод4.1 Цикл for 
string Method4(int count, string text)
{
    int i=0;
    string result = String.Empty;// выходные данные - пустая строка
    
    for (int i=0; i<count; i++)
        {
            result = result + text;
            i++;
        }
        return result;
}
string res = Method4(10, "as;dlgk");
Console.WriteLine (res);