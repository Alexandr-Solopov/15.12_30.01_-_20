// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.WriteLine("Введите меньшее число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите большее число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M >= N)
    Console.Write("Ошибка выполнения: числа введены неправильно.");
else
{
    int Natural(int N, int M)
    {
        if (N == M)
        {
            return M;
        }

        return N + Natural(N - 1, M);
    }
    int sum = Natural(N, M);
    Console.WriteLine($"Сумма натуральных чисел от M до N равна {sum}.");
}