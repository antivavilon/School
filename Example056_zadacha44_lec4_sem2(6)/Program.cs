//Задача 44. Не используя рекурсию выведите N чисел Фибоначи.первые числа Фибоначи 0 и 1.
 //           если N = 5 -> 0 1 1 2 3
Console.WriteLine("Введите число");
int lustNum = Convert.ToInt32(Console.ReadLine());
int firstFib = 0;
int secondFib = 1;
 int thirdFib =0;
 string res = String.Empty  ;
string resPrint= String.Empty;
while (firstFib + secondFib <  lustNum)
 {
      thirdFib = firstFib + secondFib ;
      res =($"{(thirdFib)} ");
    firstFib = secondFib;
    secondFib = thirdFib;
     resPrint = resPrint + res; 
}

Console.Write($"Все числа фибоначи до числа {lustNum} это: {resPrint}");
