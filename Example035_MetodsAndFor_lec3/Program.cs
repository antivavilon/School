// 1. Метод, у которого нет аргументов и он ничего не отдает.
void Method1()
{
 Console.WriteLine ("outher: Kirill Silantiev");
}

Method1();



// 2. Метод,  с аргументом "строка".

void Method2(string msg)
{
 Console.WriteLine(msg);
}
Method2("Spring");

// 2_1 Метод с аргументом "строка" и "счетчик".


void Method2_1(string msg, int count)
{
    int i = 0;
    while ( i < count  )
    {
   Console.Write(msg);
         i ++;   
    }   
}

Method2_1("Spring ", 35);
// 3 Метод без аргументов, но он возвращает данные.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method();
Console.WriteLine(year);

// 4 Метод принимает аргументы и возвращающий данные.(Внутри цикл while)
 string Method4(int count, string text)
    {
    int i = 0;
    string result = String.Empty;          
    while (i < count)
        {
        result = result + text;  
        i++;
     }       
       return  result;
    }
    string e = Method4(56, "E");
    Console.WriteLine(e);


    // 4_1 Метод принимает аргументы и возвращающий данные. (Внутри цикл for)

 string Method4_1(int count, string text)
    {
    int i = 0;
    string result = String.Empty;          
    for (i=0; i<count; i++ )
        {
        result = result + text;  
     }       
       return  result;
    }
    string f = Method4(56, "E");
    Console.WriteLine(f);

    string c = Method4_1(111,"SUN");
    Console.WriteLine(c);


 // Пример цикла for в цикле for.
 // С помощью такой конструкции в этом примере мы выводим таблицу умножения.

    for (int i = 2; i < 10; i++)
    {
        for (int j  = 2; j < 10; j++)
        {
           Console.WriteLine ($"{i} x {j} = {i*j}");
           
        }
        Console.WriteLine();  
    }