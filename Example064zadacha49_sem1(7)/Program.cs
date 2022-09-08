// Задача 49. Задайте двумерный массив. Найдите элементы у которых оба индекса четные и замените эти элементы на их квадраты.

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = new Random().Next(9);
    }
    return result;

}
int[,] test = GetArray(4, 6);


void PrintArray(int[,] arr)

{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            Console.Write(arr[k, l] + "  ");
        }
        Console.WriteLine();

    }
    Console.WriteLine("Метод PrintArray");

}
PrintArray(test);



void GetNewArray(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (m % 2 == 0 && n % 2 == 0)
            {
                array[m, n] = array[m, n] * array[m, n];
            }
            Console.Write(array[m, n] + " ");
        }
        Console.WriteLine();
    }
}

GetNewArray(test);
