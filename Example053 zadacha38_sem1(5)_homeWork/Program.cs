//Задача 38. Задайте массив вещественных чисел. 
//        Найдите разницу между максимальным и минимальным элементом массива.

int[]arr = new int [9];
int max = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(99);
    if(arr[i] > max ) max = arr [i];
}
int min = arr[0];
for (int i = 0; i < arr.Length; i++)
{
    if(arr[i] < min ) min = arr [i];
}
Console.WriteLine($"массив:[{string.Join (",",arr)}]"); 
Console.WriteLine($"Разница между минимальным и максимальным значением: {max-min}");