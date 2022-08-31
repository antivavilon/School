//Задача 40. Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник
  //         со сторонами такой длинны. Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы
    //       двух других сторон.

    Console.WriteLine("Введите первое число");
    int firstDigit = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int secondtDigit = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите третье число");
    int thirdDigit = Convert.ToInt32(Console.ReadLine());
    if(secondDigit + thirdDigit > firstDigit && firstDigit + thirdDigit > secondDigit && firstDigit +secondDigit > thirdDigit ) 
    {
        Console.WriteLine("Треугольник с такими сторонами может существовать");
    }

    else  Console.WriteLine("Треугольник с такими сторонами не возможен");
