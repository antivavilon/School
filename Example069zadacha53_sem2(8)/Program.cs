// Задача 53. Задайте двумерный массив. Напишите программу, котолрая поменяет первую и последнюю строчку массива.


/// summary  описание метода  3 слэша
/// m сторчки, n столбцы
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


/// PrintArray: int[,]matrix
void PrintArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }

}

int[,] test = GetArr(5, 7);
 PrintArr(test);



//int[,] ChangeString(int[,] array)
//{
  //  int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    //for (int i = 0; i < array.GetLength(0); i++)
    //{
     //   for (int j = 0; j < array.GetLength(1); j++)
       // {
         //   if (i == 0)
           // {
             //   int temp = array[i, j];
               //  array[i,j] = array[(array.GetLength(0) - 1), j] ;
                //array[(array.GetLength(0) - 1), j]  = temp;
                

           // }
           // Console.Write($" {array[i, j]}  ");
        //}
       // Console.WriteLine();
    //}
    //return result;
//}

//int[,]testResult =ChangeString(test);



void ChangeRows(int[,] inputMatrix)
{
    int lastRowIndex = inputMatrix.GetLength(0) - 1;
    for (int i = 0; i < inputMatrix.GetLength(1); i++)
    {
        int temp = inputMatrix[0, i];
        inputMatrix[0, i] = inputMatrix[lastRowIndex, i];
        inputMatrix[lastRowIndex, i] =  temp;
    }


}
Console.WriteLine();
Console.WriteLine("результат");

ChangeRows(test);
PrintArr(test);