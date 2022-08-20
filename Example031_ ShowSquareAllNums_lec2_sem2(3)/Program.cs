//Задачяа 22.Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел от 0 до N

//Решение с помощью цикла while
//Console.WriteLine("Ведите число от 1 до 10");
//int num =Convert.ToInt32(Console.ReadLine());
//double digit = 1;
//while (digit < num)
//{
    //Console.WriteLine(Math.Pow(digit,2));
  //  digit++;
//}


//Решение с помощью цикла for
Console.WriteLine("Ведите число от 1 до 10");
int N =Convert.ToInt32(Console.ReadLine());
for (int start=1; start <= N; start++) 
{
    Console.WriteLine(Math.Pow(start,2));
}


