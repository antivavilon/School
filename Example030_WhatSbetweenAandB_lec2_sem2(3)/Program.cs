//Задача21. Напишите программу, которая принимает на вход координаты дыух 
// и находит расстояние между ними в 2D пространстве.
//(A(3,6), B(2,1) result = 5,09
 // A(7,-5), B(1,-1) result = 2,21
//Для решения задачи используется формула(Теорема Пифагора)
//d^2= (х2— х1)^2+ (y2— y1)^2
//Использовали метод, который выводит корень: Math.Sqrt(num)
// Использовали метод, который возводит число или выражение в степень: Math.Sqrt(num,2)
// Использовали метод, который округляет до нужного нам порядка после запятой: Math.Round(num,2)
Console.WriteLine("Введите координату x точки A" );
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки A" );
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату x точки B" );
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y точки B" );
int yb = Convert.ToInt32(Console.ReadLine());
//int inter = ((7 - 1)*(7 - 1)) + ((-5 - (-1))*(-5 - (-1)));
//int inter = ((3 - 2)*(3 - 2)) + ((6 - 1)*(6 - 1));
double result = Math.Sqrt((Math.Pow(xa - xb,2)) + (Math.Pow(ya - yb,2)));;
Console.WriteLine($"Длинна отрезка:{Math.Round(result,3)}");