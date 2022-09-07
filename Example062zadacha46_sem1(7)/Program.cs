
// Задача 46. Задайте двумерный массив размером (m*n), заполненный случайными целыми числами.
int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(99);
        }
    }

    return result;

}

int[,] test = GetArray(5,7 );

void FillArray(int[,] arr)
{
    for (int l = 0; l < arr.GetLength(0); l++)
    {
        for (int k = 0; k < arr.GetLength(1); k++)
        {
            Console.Write(arr[l, k] + "\t");
            
        }
        Console.WriteLine();
    }
}
FillArray(test);






















//int[,] GetArray(int m, int n)
//{

// int[,] result = new int[m, n];
//for (int i = 0; i < result.GetLength(0); i++)
//{
//   for (int j = 0; j < result.GetLength(1); j++)
//  {
//     result[i, j] = new Random().Next(99);
//}
// }
//return result;
//}

//int[,] test = GetArray(12, 15);

//void PrintArray(int[,] arr)
//{
//   for (int k = 0; k < arr.GetLength(0); k++)
// {
//    for (int m = 0; m < arr.GetLength(1); m++)
//      Console.Write(arr[k, m] + "\t");
//    Console.WriteLine();
// }

//}

//PrintArray(test);
