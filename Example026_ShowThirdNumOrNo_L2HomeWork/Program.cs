Console.WriteLine("Ведите число");
string num = Console.ReadLine();
int size = num.Length; 
if (size < 3 )
{
   Console.WriteLine($"У числа нет третьей цифры ");  
}
else
{
   Console.WriteLine(num [2] );
}








//Console.WriteLine("Ведите число");
//int num = Convert.ToInt32(Console.ReadLine());
     //int num = new Random().Next(10, 1000);
//Console.WriteLine(num);
 
//string numString = num.ToString();
//if (num / 100 == 0 )
//{
  // Console.WriteLine($"У числа {num} нет третьей цифры ");  
//}
//else
//{
//   Console.WriteLine ($"У числа {num} третья цыфра это {numString[2]}");
//