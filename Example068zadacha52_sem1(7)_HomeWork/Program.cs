// Задача 52. Напишите программу, которая выдает среднее арифметическое каждого числа.


int[,] GetArray(int m, int n)   // Метолд, создает и наполняет  массив.
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(9);
        }
    }
    return arr;
}

int[,] test = GetArray(12, 15);


void PrintArray(int[,] array)                       // Метод выводит массив вконсоль.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "     ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}
PrintArray(test);



void ColumnMiddleNum(int[,] matrix)                    // Метод, вчисляет среднее арияметическое каждого столбца
{
    int columnSize = matrix.GetLength(0);
    double sum = 0;
    int count = 0;
    double middleNum = 0;
    while (count < matrix.GetLength(1))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
            if (j == count) sum  = sum + matrix [i, j] ;
            }

        }
        middleNum = sum  / columnSize;
        
        Console.Write( $"{Math.Round(middleNum, 2)}    ");
        count++;
        sum = 0;
    }
    
};


 ColumnMiddleNum(test);
//System.Console.WriteLine(nums);
