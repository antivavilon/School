//Задача 44. Не используя рекурсию выведите N чисел Фибоначи.первые числа Фибоначи 0 и 1.
 //           если N = 5 -> 0 1 1 2 3
Console.WriteLine("Введите число");
int lustNum = Convert.ToInt32(Console.ReadLine());
int firstFib = 0;
int secondFib = 1;
 int thirdFib =0;
string resultString= String.Empty;
while (firstFib + secondFib <  lustNum)
 {
      thirdFib = firstFib + secondFib ;
    firstFib = secondFib;
    secondFib = thirdFib;
     resultString = resultString + ($"{thirdFib} ");
}
Console.Write($"Все числа фибоначи до числа {lustNum} это: {resultString}");
