//Задача 34. Задайте массив, заполненный случайными положительными числами.
  //          Напишите программу, которая покажет количество четных чисел в массиве.

  //Первый вариант решения.
  int[]arr = new int[12];
  for (int i = 0; i <arr.Length; i++)
  {
   arr[i] = new Random().Next(999);
  }
   Console.WriteLine($"массив:[{string.Join (",",arr)}]");


  int count = 0;
  for (int i = 0; i < arr.Length; i++)
  if (arr[i] % 2 == 0) count++;
  if(count == 0) Console.WriteLine($"В этом массиве {count} четных чисел ");
  if(count == 1) Console.WriteLine($"В этом массиве {count} четнoe число ");
  if(count <= 4 && count > 1 ) Console.WriteLine($"В этом массиве {count} четных числа ");
  if(count > 4) Console.WriteLine($"В этом массиве {count} четных чисел ");
  
  
  
  //Второй вариант решения(метод).

//  int getCount(int[]array)
//  {
//    int count =0;
//    for (int i = 0; i < array.Length; i++)
//    {
//    if (arr[i] % 2 == 0) count++;
//    }
//    return count;
//  }
//
//  int resultCount = getCount(arr);
//  Console.WriteLine($"В этом массиве {resultCount} четных чисел ");
