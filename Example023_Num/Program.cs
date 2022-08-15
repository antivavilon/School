int firstDigit = 130;
int secondDigit = 5;
double result = firstDigit % secondDigit;
if (result != 0) 
{
Console.WriteLine($"Первое число не кратно второму. Остато от деления: {result}");
}
else
{
    Console.WriteLine("Первое число  кратно второму.");
}
