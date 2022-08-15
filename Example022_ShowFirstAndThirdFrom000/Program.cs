int num = new Random().Next(100, 999);
Console.WriteLine(num);
int firstDigit = num / 100;
int thirdDigit = num % 10;
Console.WriteLine($"Первая цифра числа {num} это {firstDigit}, а третье {thirdDigit} ");
