Console.WriteLine("Введите число от 100 до 1000");
int num = Convert.ToInt32(Console.ReadLine());
//int num = new Random().Next(100, 1000);
//Console.WriteLine (num);
int result = (num / 10 )% 10;
Console.WriteLine($"Вторая цифра числа {num} это: {result}");