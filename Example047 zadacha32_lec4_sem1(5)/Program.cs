//Задача 32. Напишите программу, замена элементов массива: положительные элементы замените на соответствующие
  //         отредцательные эоементы и наоборот. [-4, -8, 8, 2] -> [4, 8, -8, -2]int
  Console.WriteLine("Введите числа в массив");
  
int[] nums = new int[5];
for (int i = 0; i < nums.Length; i++)
   {
   nums[i] = Convert.ToInt32(Console.ReadLine());    
   }
   Console.Write($"массив: [{string.Join (",",nums)}]");
   Console.WriteLine();

   int[]ChangeTo( int[]arr) 
    {
     for (int i = 0; i < arr.Length; i++)
      {
       arr[i] = arr[i] *(-1);  
      }
     return arr;
    }

int[] test = ChangeTo(nums);
  Console.Write($"массив: [{string.Join (",",nums)}]");