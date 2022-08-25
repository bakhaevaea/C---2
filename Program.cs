using System;

class MyNewClass
{
    static void Main()
    {

        Console.WriteLine("Введите  число");
        int number= Convert.ToInt32(Console.ReadLine());
        taskDop(number);
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
    

   // Напишите программу, которая принимает на вход цифру, 
   // обозначающую день недели, и проверяет, является ли этот день выходным.
   
    public static void task15(int num)
    {

        if(num==6 || num==7)
        {
            System.Console.WriteLine("Выходной!");
        }
        else if (num>=1 && num<=5) {
           Console.WriteLine("Не выходной"); 
        } 
        else{
            Console.WriteLine("Не день недели"); 
        }

    }
    
    
    //  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23
    public static void taskDop(int num)
    {

        if(num%7==0 && num%23==0)
        {
            System.Console.WriteLine("Кратно одновременно 7 и 23");
        }
        else{
            Console.WriteLine("Не кратно одновременно 7 и 23"); 
        }
    }

}



