﻿// Задача.
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2.  Произвести обмен этого значения со значением первой неотсортирорванной позиции.
// 3. Повторять, пока есть неосортированные элементы.

// Метод, который  выводит массив в консоль.
int[] arr={1, 5, 4, 3, 2, 6, 7};



       void PrintArrey(int[] array)
       {
         int count = array.Length;
         for (int i = 0; i < count; i++)
         {
            Console.Write($"{arr[i]} ");
         }
           Console.WriteLine();
       }
       PrintArrey(arr);
// Метод сортировки в массиве от большего числа к максимальному.
       void SelectionSort(int[]array)
           {
      
             for ( int i = 0; i < array.Length - 1; i++)
             
             {
                int minPosition = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[j] < array[minPosition]) minPosition = j;
                }
                    int temporary = array[i];
                    array[i] = array[minPosition];
                    array[minPosition] =  temporary; 
             }


           }

SelectionSort(arr);
 PrintArrey(arr);

Создаем метод для сортировки от мень шего к большему в массиве и метод вывода массива в консоль.