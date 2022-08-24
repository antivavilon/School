//Задача 27. Напишите программу, которая принимает на вход число и выдаетсумму цыфр в числе

//1 Решение через цикл.
//Console.WriteLine("Введите Число");
//int digit = Convert.ToInt32(Console.ReadLine());
//int sum =0;
//while (digit > 0)
//{                               
 //   int a = digit % 10;
//     sum = sum + a;
//    digit = digit /10;
    
//}
//Console.WriteLine(sum);



//2 Решение через цикл в  методе.

Console.WriteLine("Введите Число");
int digit = Convert.ToInt32(Console.ReadLine());

int SumNumDigit(int num)
{
int result = 0;
while (num > 0)
{
 int a = num % 10;
  num = num / 10;
  result = result + a;
}
return result;
}

Console.WriteLine($"сумма цифр этого числа {SumNumDigit(digit)}");
//int test = SumNumDigit(digit); // Альтернативный метод вывода
//Console.WriteLine(test);   // Альтернативный метод вывода