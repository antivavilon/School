//Задача 44.1 Вывести все числа фибоначи до N, но на этот раз черз массив.



Console.WriteLine("Введите числдо");                  //Вводим заданное число 
int size = Convert.ToInt32(Console.ReadLine());
if (size < 3)                                          //Защита от ввода некоректного числа
{
    return;
}
int num =0;                                             //Создаем массив с количеством элементов равных заданному числу. 
int[]arr = new int[size+1];                             //Значения элементов равны номерам элементов.
for (int i = 0; i < size+1; i++)
{
 arr[i] = num;
 num ++;
}
 Console.WriteLine($"массив:[{string.Join (",",arr)}]"); 


 
//1. Решение .

//int firstFib = arr[1];                                    //Назначаеи первый элемент массива первым числом Ф.
//int secondFib = arr[2];                                   //Назначаеи второй элемент массива вторым числом Ф     
//int count = 1;
//string allFib = String.Empty;
//for (int i = 3; i <size; i++)                              //Цикл for начинается с 3 элемента
//{

//  if(firstFib + secondFib == arr[i])                        //Внутри цикла for делаем проверку, равна ли сумма двух чисел Ф. 
//  {                                                         //текущему индексу. Если да, то текущий индекс назначается вторым
//  secondFib = arr[i];                                        //А первое число становится элементом массива [i - count ].
//  firstFib = arr[i - count];                                 //Переменная count изначально равна единице и увеличивается с каждым                                         
//  count = 1;                                                 //срабатыванием else. С каждым срабатыванием условия if count возвращается к значению 1   
//  allFib = allFib +( $"{(arr[i])} ");
//  }
//  else
//  {
//   count++;
//  }
//}
//Console.WriteLine($"Все числа Фибоначи от 0 до {size} это: {allFib}");   //Выводим результат в консоль


//2. На основе решения создаем метод. 

string  GetAllFib(int[]array)
{
   string result = String.Empty;
   int firstFib = arr[1];                                  
   int secondFib = arr[2];                                      
   int count = 1;
   for (int i = 3; i <size; i++)                              
    if(firstFib + secondFib == arr[i])                         
     {                                                         
      secondFib = arr[i];                                       
      firstFib = arr[i - count];                                                                          
      count = 1;                    
      result = result +( $"{(arr[i])} ");
     }
    else
      {
       count++;
      }
    return result;
}


string test =  GetAllFib(arr);
//Console.WriteLine($"массив:[{string.Join (",",test)}]");
Console.WriteLine(test);




   

