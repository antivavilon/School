//Задача 45. Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
          

int size = 12;
int[]arr = new int [size];

for (int  i = 0;  i < size;  i++)
{
    arr[i] = new Random().Next(9);
}
Console.WriteLine($"массив:[{string.Join (",",arr)}]");


int[] CoppyArr(int[]array)
{
int[]result = new int[array.Length];
for (int i = 0; i <array.Length; i++)
{
    result[i] = array[i];
}

return result;
}


int[]test = CoppyArr(arr);
Console.WriteLine($"массив:[{string.Join (",",test)}]");