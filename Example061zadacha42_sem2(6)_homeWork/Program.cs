//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
int[] ToDouble(int digit)                         // Создаем метод. Аргумент число, которе нужно конвертировать. На выходе массив с  двоичным числом
{
    int num = 2;
    int count = 2;                                 // Вычисляем длинну массива
    while (num * 2 < digit)
    {
        num = num * 2;
        count++;
    }
    int[] arr = new int[count];                      // Создаем массив, в котором возводим цыфру 2 нужное количество раз.
    int help = 2;
    arr[count - 1] = 1;
    arr[count - 2] = 2;
    for (int i = count - 3; i >= 0; i--)               // Наполгяем массив с конца. Последний элемент равен 1, следующий равен 2.
    {
        help = help * 2;                               // В третьем с конца  возводим число во вторую  степень(2*2) , в след. эл. (4*2                                      
        arr[i] = help;                               // и т.д.
    }
    //Console.WriteLine($"массив:[{string.Join (",",arr)}]");

    int[] result = new int[count];                                       // Создаем массив длч непосредственно двоичного числа
                                                                         //Console.WriteLine($"массив:[{string.Join (",",result)}]");
    int sum = 0;
    for (int i = 0; i < count; i++)
    {
        sum = sum + arr[i];
        //Console.WriteLine(sum);
        if (sum <= digit) result[i] = 1;
        if (sum > digit)
        {
            result[i] = 0;
            sum = sum - arr[i];
        }

    }
    return result;
}

int[] test = ToDouble(103);                                            // Создаем массив и тестируем метод.
Console.WriteLine($"массив:[{string.Join(",", test)}]");                 // Выводим массив с двоичным числом            



//578 -> [1,0,0,1,0,0,0,0,1,0]      
//103 -> :[1,1,0,0,1,1,1]
//47 -> [1,0,1,1,1,1]

                                                                                                                                                                                                                                                                                                                                                                   