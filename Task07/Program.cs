﻿/*7. Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает последнюю цифру
этого числа.
456 -> 6
782 -> 2
918 -> 8*/

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 1000)
    Console.WriteLine($"Последняя цифра в числе {number} равна {number % 10}");
else
    Console.WriteLine("Вы ввели не трех значное число");
