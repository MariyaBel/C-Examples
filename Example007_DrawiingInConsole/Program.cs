﻿Console.Clear();
int xa = 30, ya = 1;// Задали координаты первой вершины треугольника
int xb = 1, yb = 20;// Задали координаты второй вершины
int xc = 60, yc = 20;// Задали координаты третьей вершины

Console.SetCursorPosition(xa, ya); // Установить курсор на координаты первой вершины
Console.WriteLine("+");// Отметить вершину +

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb;// Присваеваем переменной х координаты первой вершины

int count = 0;// установили счетчик на 0

while (count < 10000)//размер цикла
{
    int what = new Random().Next(0, 3);// Присваеваем переменной what случайное значение 0 1 2  - этим мы выбираем 1 из трех точек
    if (what == 0) // Если была выбрана первая вершина то задаем точку на середине расстояния между 
    {
        x = (x + xa) / 2;   //Находим середину расстояния с 1й вершиной
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2; //Находим середину расстояния с 2й вершиной
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2; //Находим середину расстояния с 3й вершиной
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition(x, y);// Устанавливаем курсор на полученную точку
    Console.WriteLine("+");// Ставим там +
    count++; //Увеличиваем счетчик на 1 
}
