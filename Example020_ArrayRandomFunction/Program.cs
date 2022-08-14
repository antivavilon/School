 void FillArray(int[]collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0,10);
        index++; 
    }

}

 сдуфк
 
array[7] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array, 12);
Console.WriteLine(pos);

