﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.WriteLine("Enter a number");
//  int number = int.Parse (Console.ReadLine());
//  if (number >= 100&&number<1000)
//  {
//     Console.WriteLine ("number is " + number%100/10);
//  }
//  else 
//  {
//      Console.WriteLine("Wrong number");
//  }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// Console.WriteLine("enter day of the week (1-7)");
// int day = int.Parse(Console.ReadLine());
// if (day == 6 || day == 7)
// {
//     Console.WriteLine($"{day} -> yes");
// }
// else if (day > 7 || day<1 )
// {
//     Console.WriteLine($"wrong number");

// }
// else 
// {
//     Console.WriteLine($"{day} -> no");
// }




//int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));
// // ФУНКЦИИ------------------------------------------------------------------------------------------------------

// // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
using System.Data;
using System.Globalization;




int number = ReadInt("Введите число ");
 int count = number.ToString().Length;
 Console.Write(MakeArray(number, count));
 int ReadInt(string message)
 {
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
 }
int MakeArray(int number , int count )
{
    int result = 0;
    if(count<3)
    {
        Console.Write("Нет третьей цифры ");
    }
    else
    {
    int c = 1;
    for(int i = count;i > 3;i--)
    {
        c = c*10;

    }
    result = (number / c )%10;
    
    
    }
    return result;
}

