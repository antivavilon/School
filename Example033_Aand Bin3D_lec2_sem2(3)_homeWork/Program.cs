//Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//Референс формулы без корня (xa - xb)*(xa -xb) + (ya - yb) + (za - zb)*(za - zb)

//Использовали метод, который выводит корень: Math.Sqrt(num)
// Использовали метод, который возводит число или выражение в степень: Math.Sqrt(num,2)
// Использовали метод, который округляет до нужного нам порядка после запятой: Math.Round(num,2)
Console.WriteLine("Введите значение координаты x точки A" );
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты y точки A" );
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты z точки A" );
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты x точки B" );
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты y точки B" );
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение координаты z точки B" );
int zb = Convert.ToInt32(Console.ReadLine());
//int inter = ((7 - 1)*(7 - 1)) + ((-5 - (-1))*(-5 - (-1)));
//int inter = ((3 - 2)*(3 - 2)) + ((6 - 1)*(6 - 1));

double result = Math.Sqrt((Math.Pow(xa - xb,2)) + (Math.Pow(ya - yb,2)) + (Math.Pow(za - zb,2)));
Console.WriteLine($"Длинна отрезка:{Math.Round(result,2)}");