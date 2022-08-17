// 17. Напишите программу, 
// которая на вход принимает координаты точки
//(X и Y),причем x не = 0, y не = 0 и выдает номер четверти плоскости,
// в которй находится эта точка



Console.WriteLine("Введите координату по оси x:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату по оси y:");
int y = Convert.ToInt32(Console.ReadLine());
if(x > 0 && y > 0 ) Console.WriteLine("Первая четверть");
if(x < 0 && y > 0 ) Console.WriteLine("Вторая четверть");
if(x < 0 && y < 0 ) Console.WriteLine("Третья четверть");
if(x > 0 && y < 0 ) Console.WriteLine("Четвертая четверть");