// Напишите программу которая на вход принимает координаты 2х точек, 
//а на выход выдает расстояние между ними
//a(3,6), b(2,1)  - 5,09
// a (7,-5); b(1,-1)  - 7,21
//формула расстояния = Квадратный Корень из суммы квадратов разниц каждой из координат 
// Distance = SQR((x2-x2)^2+(y2-y1)^2)
// Math.Sqrt - корень, Math.Pow (основание,степень) - возведение в степень

Console.Clear();
Console.WriteLine("Input coordinates of the first dot (X1)");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinates of the first dot(Y1)");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input coordinates of the second dot (X2)");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinates of the first dot(Y2)");
int y2 = Convert.ToInt32(Console.ReadLine());

double n = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));// Math.Sqrt - корень, Math.Pow (основание,степень) - возведение в степень

Console.WriteLine("The distance is " + n);

// //Console.Clear();
// Console.WriteLine("Введите координаты двух точек");
// Console.Write("Введите x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double L = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// Console.WriteLine("Расстояние между точками равно: " + L);
