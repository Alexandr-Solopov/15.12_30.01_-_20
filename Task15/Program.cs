/*15: Напишите программу, которая
 принимает на вход цифру, 
 обозначающую день недели, и проверяет, 
 является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.Write("Введите число в диапозоне от 1 до 7: ");
string a = Console.ReadLine();
if (a == "1")
{
    Console.WriteLine("нет");
}
else if (a == "2")
{
    Console.WriteLine("нет");
}
else if (a == "3")
{
    Console.WriteLine("нет");
}
else if (a == "4")
{
    Console.WriteLine("нет");
}
else if (a == "5")
{
    Console.WriteLine("нет");
}
else if (a == "6")
{
    Console.WriteLine("да");
}
else if (a == "7")
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("Нет такого числа");
}