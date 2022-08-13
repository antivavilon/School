int[ ]array = {3, 12, 8, 19, 333, 1, 91,};
int n = array.Length;
int find = 333;
int index = 0;
while (index < n)
{
 if(array[index]==find)
 {
    Console.WriteLine (array[index]);
 }
 index++;
}