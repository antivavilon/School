//Задача 29. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int[]CreatArray(int size)
{
int[] result = new int[size];
for (int i = 0; i < size; i++)
{
    result[i] = new Random().Next(1,6);
}
   return result;
}

int[] resultArr = CreatArray(45);
Console.WriteLine($"массив:[{string.Join (",",resultArr)}]"); 