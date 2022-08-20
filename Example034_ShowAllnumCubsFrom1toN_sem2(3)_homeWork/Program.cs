//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
double digitHelp = 1;
 while(digitHelp <= N)

{
    double digitCube = Math.Pow(digitHelp,3);
    digitHelp ++;
    Console.WriteLine(digitCube);
}