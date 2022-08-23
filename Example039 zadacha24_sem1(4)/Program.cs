//Задача 24. Напишите программу, которая принимает на вход число А и выдает сумму чисел от 1 до A.
//Console.WriteLine("Веедите число");
//int digit = Convert.ToInt32(Console.ReadLine());
 //    int work =  digit;
//int count = 0;
//while (work != 0) 
//{
 //  work=work /10;
//    count++; 
//}
//if(count == 1) Console.WriteLine($"В цыфре {digit} {count} число");
//if(count == 2 || count == 3 || count == 4 ) Console.WriteLine($"В цыфре {digit} {count} числа");
//if(count == 5 || count == 6 || count == 7 || count == 8 || count == 9 || count == 10) Console.WriteLine($"В цыфре {digit} {count} чисел");


//Решение с помощью метода     (от Михаила)
Console.WriteLine("Веедите число");
int num = Convert.ToInt32(Console.ReadLine());

int GetCountNumber(int number)

      {
          
          int count = 0;
          while (number > 0)
          {
               number = number /10;
           count++;    
          }
          return count;
      }


     Console.WriteLine($"{GetCountNumber(num)}");

    