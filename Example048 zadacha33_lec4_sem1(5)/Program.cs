
//Задача 33. Задайте массив. Напишите прогшрамму, которая определяет, присутствует ли заданное число в массиве.


int[]MakeArr(int size)
{
int[] result = new int[size];
for (int i = 0; i < result.Length; i++)
 result[i] = new Random().Next(10);
return result;
}

int[]test = MakeArr(12);
//Console.Write($"массив:[{string.Join (",",test)}]"); 


void CheckNum(int[]arr, int digit)
{

    Console.WriteLine($"Заданное число:{digit}");
    Console.WriteLine( );
    Console.Write($"массив:[{string.Join (",",test)}]"); 
    Console.WriteLine( );

int N = arr.Length;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
 if(arr[i] == digit) Console.WriteLine("Такое число есть в массиве");
 

 
 if(arr[i] == digit)  count = arr[i];
 
 
  
}
if (count == 0)  Console.WriteLine("Такого числа в массиве нет");
   // Console.WriteLine($"Заданное число:{digit}");
}



CheckNum(test, 3);