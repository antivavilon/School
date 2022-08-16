Console.WriteLine("Введите число от 1 до 7");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 1 || num == 2 || num == 3 || num == 4 || num == 5 )
{
    Console.WriteLine("Это будний день.");
}
if (num == 6 || num ==7 )
{
    Console.WriteLine("Это выходной день!");     
}
