//Задача 28. Напишите программу, которая принимает на вход число N, а выдает произведение чисел от 1 до N.
 чConsole.WriteLine("Введите число");
int digit = Convert.ToInt32(Console.ReadLine());
 int result =1;
for (int i = 1; i <= digit; i++)
{
  result = result * i ;
Console.WriteLine(result);

}
Console.WriteLine(result);