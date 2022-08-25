using System;

class MyNewClass
{
    static void Main()
    {

        Console.WriteLine("Введите  число");
        int number= Convert.ToInt32(Console.ReadLine());
        task13(number);
    }

    // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
    // вторую цифру этого числа 
    public static void task10(int num)
    {
        if((num>=100 && num<1000) || (num>-1000 && num<=-100))
        {
            System.Console.WriteLine($"{(num % 100) / 10}");
        }
        else   Console.WriteLine("Число не трехзначное");
    }
    
    //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    public static void task13(int num)
    {

        if(num.ToString().Length>=3)
        {
            System.Console.WriteLine($" Третья цифра {num.ToString()[2]}");
        }
        else   Console.WriteLine("Третьего числа нет");
    }
    
}



