// Задача 67: Напишите программу, 
//которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9



// int Factorial (int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6

// int num = number % 10;
//     number = number / 10;
//     sum = sum + num;
// 453 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumDigit(number);
Console.WriteLine(sumDigit);

int SumDigit (int n)
{    
    if(n == 0) return 0;
    return n % 10 + SumDigit(n / 10);
}

