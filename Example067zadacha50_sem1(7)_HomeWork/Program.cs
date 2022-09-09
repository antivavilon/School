int[,] GetArray(int m, int n)
{
int [,] result = new int[m, n];
for (int i = 0; i < result.GetLength(0); i++)
{
    for (int j = 0; j < result.GetLength(1); j++)
    {
        result[i, j] = new Random().Next(9);
    }
}
return result;

}
int [,] test = GetArray(12,7); 

void PrintArray(int[,] arr)
{
for (int k = 0; k < arr.GetLength(0); k++)
{
    for (int l = 0; l <arr.GetLength(1); l++)
    {
        Console.Write(arr[k, l] + "   " );
    }
Console.WriteLine();
}


};
PrintArray(test);

void ChekNum(int[,]arr,int m, int n )
{
    int search = 0;
    bool find = false;
for (int i = 0; i < arr.GetLength(0); i++)
{
for (int j = 0; j <arr.GetLength(1); j++)
{
    if(i == m && j == n) 
    {
        find = true;
        search = arr[i, j];
        
        Console.WriteLine( $" Число с индексом строки {m} и индексом столбца {n}: {arr[i,j]}");
    }
}
}
if (!find) System.Console.WriteLine($"Числа с индексом строки {m} и индексом столбца {n} в массиве не существует");

}


ChekNum(test,5,3);