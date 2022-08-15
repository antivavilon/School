int num = new Random().Next(10, 100);
Console.WriteLine($"Рандомное числож: {num}");   // конкатенация
int firstDigit = num / 10;
int secondDigit = num % 10;
int max =  firstDigit;
int min = 0;
if(firstDigit > max) max = firstDigit;
 if(secondDigit > max) max = secondDigit;
 if (max == firstDigit)
    { 
     min = secondDigit;
    }
 if (max == secondDigit) 
    {
    min = firstDigit;
    }
 Console.WriteLine($"Максимальная цыфра в числе {num} это {max}");
 Console.Write($"Минимальная цыфра в числе {num} это {min}");
