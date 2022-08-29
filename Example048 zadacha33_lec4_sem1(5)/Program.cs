
//Задача 33. Задайте массив. Напишите прогшрамму, которая определяет, присутствует ли заданное число в массиве.


int[]MakeArr(int size)                                       //  Пишем метод, который создает и рандомно наполняет массив
{
int[] result = new int[size];
for (int i = 0; i < result.Length; i++)
 result[i] = new Random().Next(10);
return result;
}

int[]test = MakeArr(12);                                      // Создаем массив из 12 элементов, с помощью метода MakeArr
Console.Write($"массив:[{string.Join (",",test)}]");           // Тестовый вывыод массива в консоль
Console.WriteLine();                                           //Переход но новую строчку для красивого вида вконсол


void CheckNum(int[]arr, int digit)                             // Пишем void метод, который принимает массив и переменную со значением загаданного числа.
{
int N = arr.Length;
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
 if(arr[i] == digit)  count++;  
}
  Console.WriteLine($"Заданное число:{digit}");
if (count == 0)  Console.WriteLine("Такого числа в массиве нет");
if (count > 0)  Console.WriteLine($"Таих чисел в массиве: {count}");
}
CheckNum(test, 5);                                                         // Тестируем метод ( Вставляем в метод, ранее созданный массив и загаданное число)



//Лекционное решение.

//int []testArray = {-1, -2, 0, 1,2};
//Console.WriteLine("Введите числ");
//int searchElement = Convert.ToInt32(Console.ReadLine());
//bool foundResult = false;
  //  for (int i = 0; i < testArray.Length; i++)
  //  {
     //   if(testArray[i] == searchElement)
     //   {
     //       foundResult = true;
     //       break;
   //     }
  //  }

//if (foundResult) Console.WriteLine($"Элемент {searchElement} присутствует");
//else Console.WriteLine($"Элемент {searchElement} отсутствует");



//Лекционное решение.(Со строками)

//int []testArray = {-1, -2, 0, 1, 2};
//Console.WriteLine("Введите числ");
//int searchElement = Convert.ToInt32(Console.ReadLine());
//string foundResult = "не найден";
  //  for (int i = 0; i < testArray.Length; i++)
 //   {
 //       if(testArray[i] == searchElement)
  //      {
     //       foundResult = "найден";
   //         break;    
   //     }
 //   }

//if (foundResult == "найден") Console.WriteLine($"Элемент {searchElement} присутствует");
//else Console.WriteLine($"Элемент {searchElement} отсутствует");
 