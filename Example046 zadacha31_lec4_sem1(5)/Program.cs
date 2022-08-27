//Задача 31. Создайте массива мз 12 элементов, заполненный случайными числами из промежутка (-9,9).
//           Найдите сумму положительных и отредцательных элементов массива. 


int [] CreatArray(int size)             //Метод, который создает и наполняет рандомными числами массив.
 {
int []result = new int[size];
 for(int i=0; i < size; i++)
 {
    result [i] = new Random().Next(-9,9);
 }
return result;
 }

int [] test = CreatArray(12);          //Создаем массив с помощью метода

int[] NegPos(int[]arr )                   //Метод, который выводит сумму отред. и сумма полож. чисел в массиве из двух элементов.
{
int[]result = new int[2];
int digitPos = 0;
int digitNeg = 0;
for (int i = 0; i < arr.Length; i++)
 {
    if(arr[i] > 0)  digitPos = digitPos + arr[i];
    else  digitNeg = digitNeg + arr[i];
     result[0] = digitNeg;
     result[1] = digitPos;
 }
 return result;
}
int[]negoPos = NegPos(test);                     //Подставляем массив ко второй фунуции, получаем две суммы чисел (по условию заадачи)

Console.WriteLine($"массив: [{string.Join (",",test)}]");
Console.WriteLine($"Суммы отредцательных и положительных чисел массива: [{string.Join (",",negoPos)}]");



// Простое решение с циклом while



//int[] arr = new int [12];
//int i = 0;
//int nDigit = 0;
//int pDigit = 0;
//while( i < arr.Length)
//{
//arr[i] = new Random().Next(-9,9);

//    if(arr[i] < 0)  nDigit = nDigit + arr[i];
//    if(arr[i] > 0)  pDigit = pDigit + arr[i];   
//    i++;
//}
//Console.WriteLine($"массив:[{string.Join (",",arr)}]");
//Console.WriteLine($"сумма отредцательных чисел массива равна:{nDigit}");
//Console.WriteLine($"сумма положительных чисел массива равна:{pDigit}");










 