// Задача 55. Задайте дмумерный массив. Напишиье программу, которая меняет стролки на столюцы. В случае, если это не возможно,
//программа должна вывести сообщение для пользователя.

int[,] GetArr(int m, int n)
{


    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(9);
        }
    }
    return result;
}
int[,] test = GetArr(6, 9);

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}   ");
        }
        Console.WriteLine();
    }
}

PrintArr(test);

int[,] ChangeRowToColumn(int[,] arr)
{
    int[,] result = new int[arr.GetLength(1), arr.GetLength(0)];
    int count = 0;
    int resultRow = 0;
    int resultColumn = 0;

    if (count <= arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                result[resultRow, resultColumn] = arr[i, j];
                resultRow++;
            }
            resultColumn++;
            resultRow = 0;

        }
        count++;
        Console.WriteLine(count);

    }

    return result;
}

Console.WriteLine("Результат");
int[,] resultTest = ChangeRowToColumn(test);
PrintArr(resultTest);




