/*18: Напишите программу, которая 
1.по заданному номеру четверти, показывает диапазон
возможных координат точек в этой четверти (x и y).*/

Console.WriteLine("Введите номер четверти: ");
int numberRange = Convert.ToInt32(Console.ReadLine());

string range = Range(numberRange);
System.Console.WriteLine(range);
Console.WriteLine();

Console.WriteLine();

string Range (int num)
{
    if (num == 1) return "x > 0 && y > 0";
    if (num == 2) return "x < 0 && y > 0";
    if (num == 3) return "x < 0 && y < 0";
    if (num == 4) return "x > 0 && y < 0";

    return "Не корректные данные";
}