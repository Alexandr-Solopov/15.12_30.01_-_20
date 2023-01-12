// Задача 25: Напишите цикл, который принимает
// на вход два числа (A и B) и возводит число A
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




Console.Write ("Введите A: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());


Console.Write ("Введите B: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = firstNumber;

for (int i = 1; i < secondNumber; i ++) 
  sum = sum*firstNumber;

 Console.WriteLine($"Число {firstNumber} в степени {secondNumber} равно {sum}");