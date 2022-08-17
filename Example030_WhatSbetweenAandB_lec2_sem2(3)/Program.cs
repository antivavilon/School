// Напишите программу, которая принимает на вход координаты дыух 
// и нгаходит расстояние между ними в 2D пространстве.A(3,6), B(2,1)
int xa = 7;
int ya = -5;
int xb = 1;
int yb = -1;
int xc = xa - xb;
int yc = ya - yb ;
//int inter = ((xa - xb)*(xa - xb)) + ( (ya - yb)*(ya - yb) )
int inter = ((7 - 1)*(7 - 1)) + ((-5 - (-1))*(-5 - (-1)));
//int inter = ((3 - 2)*(3 - 2)) + ((6 - 1)*(6 - 1));
double result =Math.Sqrt(inter);
Console.WriteLine($"Длинна отрезка: {result}");