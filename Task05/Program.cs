/*5. Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"
Итерация №2*/

Console.WriteLine("Введите целое число N");
int number = Convert.ToInt32(Console.ReadLine());
int startnumber = number * -1;
while (startnumber <= number)
{
   if (startnumber == number)
   {
        Console.Write($"{startnumber}");
        break;
   }
   Console.Write($"{startnumber} ,");
   startnumber = startnumber + 1;
}
