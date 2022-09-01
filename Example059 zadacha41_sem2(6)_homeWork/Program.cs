//Задача 41. Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше нуля ввел пользователь.

int[] GetArray (int size)
{
 int[] result = new int[size];
 Console.WriteLine("Введите число");
 for(int i = 0; i < size; i++)
 {
  result[i] = Convert.ToInt32(Console.ReadLine());
  
 }
 return result;
}
int[] test = GetArray(5);
Console.Write($"массив:[{string.Join (",",test)}]"); 
Console.WriteLine();
int CountNum(int[]array)

{
 int count=0;  
 for (int i = 0; i < array. Length; i++)
 {
  if( array[i] < 0 ) count++; 
 }

 return count;

}

int countNegoDigit = CountNum(test);

//Console.WriteLine($"В этом массиве {countNegoDigit} отр");
if(countNegoDigit== 0) Console.WriteLine($"В этом массиве {countNegoDigit} отредцательных чисел ");
  if(countNegoDigit == 1) Console.WriteLine($"В этом массиве {countNegoDigit} отредцательное число ");
  if(countNegoDigit <= 4 && countNegoDigit > 1 ) Console.WriteLine($"В этом массиве {countNegoDigit} отредцательных числа ");
  if(countNegoDigit > 4) Console.WriteLine($"В этом массиве {countNegoDigit} отредцательных чисел ");
  