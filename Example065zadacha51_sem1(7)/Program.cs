// Задача 51. Найти сумму элепментов главной диагонали.
int[,] GetArray(int m, int n, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(max);
        }

    }
    return result;
}

int[,] test = GetArray(9, 7, 7);

void PrintArray(int[,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        for (int l = 0; l < arr.GetLength(1); l++)
        {
            Console.Write(arr[k, l] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine("PrintArray");
}



PrintArray(test);

int GetDiagonale(int[,] arr)
{
    int result = 0;
    for (int m = 0; m < arr.GetLength(0); m++)
    {
        for (int n = 0; n < arr.GetLength(1); n++)
        {
            if (m == n) result = result + arr[m, n];
        }

    }
    return result;
}
int sumNums = GetDiagonale(test);
Console.WriteLine(sumNums);