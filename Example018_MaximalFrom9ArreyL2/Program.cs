
//int Max(int arg1, int arg2, int arg3)
//    {
//    int result = arg1;
//    if (arg2 > result ) result = arg2;
//    if (arg3 > result ) result = arg3;
//    return result;
//    }
//int a1 = 6;
//int b1 = 21;
//int c1 = 39;
//int a2 = 12;
//int b2 = 23;
//int c2 = 33;
//int a3 = 2311;
//int b3 = 23;
//int c3 = 5235;
//int max = Max(Max(a1, b1, c1),
//               Max(a2, b2, c2),
//               Max(a3, b3, c3)
//              );
//Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
     return result;  
}

int[] array = {6, 21, 39,12, 21, 33, 1116, 23, 999};
int max = Max (Max(array[0], array[1], array[2]),
               Max(array[3], array[4], array[5]),
               Max(array[6], array[7], array[8]));
Console.WriteLine(max);


