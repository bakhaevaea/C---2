using System;

class MyNewClass
{
    static void Main()
    {
    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
    // вторую цифру этого числа 
        Console.WriteLine("Введите трехзначное число");
        int number= Convert.ToInt32(Console.ReadLine());
        task10(number);
    }

    public static void task10(int num)
    {
        if((num>=100 && num<1000) || (num>-1000 && num<=-100))
        {
            System.Console.WriteLine($"{(num % 100) / 10}");
        }
        else   Console.WriteLine("Число не трехзначное");
    }
}



