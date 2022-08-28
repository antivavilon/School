//Задача 35. Задайте одномерный массив из 123 случайных чисел.
 //           Найдите количество элементов массива, значения которых лежат в отрезке[10, 99]


 int[] CreatArr(int size)                           // Создаем метод, создающий и заполняющий массив
{
int[] result = new int[size];
for (int i = 0; i < result.Length; i++)
result[i] = new Random().Next(235);
return result;
}
int[]test = CreatArr(123);                                  // Cоздаем  и наполняем массив с помощью метода CreatArr

Console.WriteLine($"массив:[{string.Join (",",test)}]");    // Выводим массив (проверка)



int  HowManyNums(int[]array)                                //  Создаем метод, с счеткиком чисел от 0 до 100 и выдающий значение этого счетчика в конце                     
{
    int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] > 0 && array[i] < 100 ) count++;   
    
}
return count;
}
 
int cou = HowManyNums(test);                                   // Создаем переменную счетчика и подключаем кней метод с введенным в него массивом
Console.WriteLine(cou);                                       // Выводим значение счетчика