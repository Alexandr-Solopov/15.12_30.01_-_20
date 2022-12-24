/*Задача 19

Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций 
(целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да*/
 
Console.WriteLine ("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 9999 || num > 999999)
{
    Console.WriteLine("Введите правильное пятизначное число: ");
    return;
}
    if (num >=10000)
    {
        int num1 = num / 10000;
        int num2 = num % 10;
        if (num1 == num2)
        {
            num = num /10;
            int num3 = num / 100;
            int num4 = num % 10;
            Console.WriteLine("Да");
        }
          else Console.WriteLine("Нет");
    }