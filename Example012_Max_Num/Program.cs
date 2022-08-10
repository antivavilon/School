Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число");
int numB = Convert.ToInt32(Console.ReadLine());
int max = numA;
if(numA > max) max = numA;
if(numB > max) max = numB;
Console.Write("Максимальное число:");
Console.WriteLine(max);