int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
            result[i, j] = i + j;
    }

    return result;


}


int[,] test = GetArray(3, 9);

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


}
PrintArray(test);