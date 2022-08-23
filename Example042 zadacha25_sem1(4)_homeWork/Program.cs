//Задача 25. Напишите цикл, который  на вход принимает два числа (А и B)  и возводит A в натуральную степень B.

//Console.WriteLine("Введите числа А");
// int A = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите числа B");
//int B = Convert.ToInt32(Console.ReadLine());
//int  result = A;
//for (int i = 0; i < B-1; i++)
//{
 //     result = result * A ;
//}
//Console.WriteLine(result);

//Решение задачи с помощбю метода.
Console.WriteLine("Введите числа А");
 int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа B");
int B = Convert.ToInt32(Console.ReadLine());
int Method(int firstDigit, int secondDigit)
{
int result = firstDigit;
for (int i = 0; i < secondDigit-1; i++)
{
    result = result * firstDigit;
}
 return result;
}
 Console.WriteLine($"числож: {Method( A, B)}");
