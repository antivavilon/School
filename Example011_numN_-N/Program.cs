Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
    
int negativeNum = num * (-1);
   while(negativeNum <= num)
      {
       Console.WriteLine(negativeNum);
       negativeNum++;
       }
       
       