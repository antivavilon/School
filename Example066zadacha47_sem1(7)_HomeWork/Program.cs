
// Задача 47. Задайте двумерный массив размером  m + n, заполненный случайными, вещественными числами.

double[,] GetArray(int m, int n)
{

    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 9);

        }
    }
    return result;
}

double[,] test = GetArray(7, 12);

void PrintArr(double[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            Console.Write(arr[k, l] + "   ");
        }
        Console.WriteLine();
    }
}
PrintArr(test);