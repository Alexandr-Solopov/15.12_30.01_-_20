// Задача 69: Напишите программу, 
//которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8



// int Factorial (int n)
// {
//  // 1! = 1
//  // 0! = 1
//  if(n == 1) return 1;
//  else return n * Factorial(n-1);
// }
// Console.WriteLine(Factorial(3)); // 1 * 2 * 3 = 6


Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int exponentiati = Exponentiation(firstNumber, secondNumber);
Console.WriteLine(exponentiati);


int Exponentiation(int firstNum, int secondNum)
{
    if(secondNum == 0) return 1;
    return firstNum * Exponentiation(firstNum, secondNum - 1);
}

