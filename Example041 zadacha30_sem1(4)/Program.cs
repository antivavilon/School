//Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//int[] array = new int[8];
//void ArrayFill(int[]arr)
 //{
  //  int length = arr.Length;
    
    //  for ( int i = 0 ; i < length; i++)
     // {
      //     arr[i] = new Random().Next(0,2);
    
   //   }      
 //}

 //void PrintArray(int[]arr)
  // {
   //int length = arr.Length;
   //for ( int i = 0; i < length; i++)
    //  {
     // Console.Write($"{arr[i]} ");
      //}
  // }
 //ArrayFill(array);
 //PrintArray(array);
 
 //Решение с помощью возвращающих методов. (от Михаила).

int[] GerBinaryArray (int size)
{

int [] result = new int [size];
for (int i = 0; i < result.Length; i++)

  result[i] = new Random().Next(2);
   
return result;
}
 
 int[] test = GerBinaryArray (8);
 Console.WriteLine($"массив:[{string.Join (",",test)}]");
