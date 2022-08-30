//Задача 39. Напишите программу, которая перевернет одномерный массив (полследний элемент будет на первом месте, а первый на последнем.)


//1. Переворачиваем массива в другой массив (в первый элемиент нового массива кладется значение последнего элемента первогомассива) в рамках одного массива. 

//Console.WriteLine("Введите длинну мапссива");
//int size = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[size];
//for (int i = 0; i < size; i++)
//{
 //   array[i] = new Random().Next(9);
//}

//Console.WriteLine($"массив:[{string.Join (",",array)}]");  

//int lastArray = size - 1;
//int[]arrayResult =new int[size];
//for (int i = 0; i < size; i++)
//{
 // arrayResult[i] = array[lastArray - i] ;
//}

//Console.WriteLine($"массив:[{string.Join (",",arrayResult)}]");  



//2. Метод, создающий массив. В качестве аргументов длина, минимальное значение в массиве, минимальное значение в массиве)
   // от Михаила.
int [] GetArray(int size, int minValue, int maxValue)
        {
       int[]result = new int[size];
       for (int i = 0; i < size; i++)
       {
       result[i] = new Random().Next(minValue, maxValue+1); 
       }
       return result;
        }


        int[]nums = GetArray(12,0,9);
        Console.WriteLine($"массив:[{string.Join (",",nums)}]");  


//3. Метод принимающий в качестве аргумента массив. И создающий его копию по размеру, но перевернутый наоборот.
   // от Михаила.
       // int[]CopyArray(int[]arr)
       // {
       //  int[]result = new int[arr.Length];
       //  for (int i = 0; i < arr.Length; i++)
      //   {

       //    result[i] = arr[arr.Length-1-i] ;
       //  }
      //   return result;
    //    }

   //     int[] resultTest = CopyArray(nums);
 //       Console.WriteLine($"массив:[{string.Join (",",resultTest)}]");  

    //6. Метод принимающий в качестве аргумента массив. И создающий его копию по размеру, но перевернутый наоборот.
   // от Михаила.
   void ReverseArray(int[] inArray)
   {
    int temporary = 0;
    for (int i = 0; i < inArray.Length/2; i++)
    {
     temporary = inArray[i];
     inArray[i] = inArray[inArray.Length -1  - i];
     inArray[inArray.Length - 1 - i] = temporary;
    }   
   }

   ReverseArray(nums);

   Console.WriteLine($"массив:[{string.Join (",",nums)}]");  