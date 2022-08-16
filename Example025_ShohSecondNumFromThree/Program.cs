int num = new Random().Next(100, 1000);
Console.WriteLine (num);
int result = (num / 10 )% 10;
Console.WriteLine($"Вторая цифра числа {num} это {result}");