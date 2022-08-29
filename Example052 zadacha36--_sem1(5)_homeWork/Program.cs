//Задача 36. Задайте одномерный массив, заполненный случайными числами.
  //          Найдите сумму элементов стоящих на нечетных позициях.

  int[]arr = new int[12];
  int sum = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(9);
  }
  for (int i = 0; i < arr.Length; i = i + 2)
  {
    sum = sum + arr[i];
  }

  Console.WriteLine($"массив:[{string.Join (",",arr)}]");
  Console.WriteLine(sum);