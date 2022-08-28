//Задача 37. Найдите произведение пар чисел в одномерном массиве.
  //         Парой считаем первый и последний элемент, второй и предпоследний и т. д.
    //         Результат запишите в новом массиве.[1, 2, 3, 4, 5] -> [5, 8, 3]



int[] CreatArr (int size)
{
 int[]result = new int[size];

  for (int i = 0; i < result.Length; i++)
  {
    result[i] = new Random().Next(10);
  }
 return result;
}

int[]test = CreatArr(9);
Console.WriteLine($"массив:[{string.Join (",",test)}]"); 



int[]TransformArr(int[]arr)
{
     int[]result = new int [arr.Length];
     int N = arr.Length;
     int t = 1; 
     for (int i = 0; i < result.Length / 2; i++)
     { 
        result [i] = arr[i] * arr[N-t];
        t++;
     }
    return result;
}

int[]testResult = TransformArr(test);
Console.WriteLine($"массив:[{string.Join (",",testResult)}]"); 
