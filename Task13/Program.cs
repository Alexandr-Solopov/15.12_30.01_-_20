﻿/*13: Напишите программу, которая выводит 
третью цифру заданного числа или сообщает, 
что третьей цифры нет. Выполнить с помощью 
числовых операций (целочисленное 
деление, остаток от деления).

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет, будет: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}