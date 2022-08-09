Console.WriteLine("Введите первое число");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ввторое число");
int numB = Convert.ToInt32(Console.ReadLine());
if(numA / numB == numB )
   {
    Console.WriteLine(numA  + "является квадратом" + numB);
   }
   else
   {   
    Console.WriteLine(numA + " не является квадратом" + numB);    
   }