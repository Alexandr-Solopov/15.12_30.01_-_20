// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.


// Console.WriteLine("Enter first digit: ");
// int first = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second digit: ");
// int second = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter third digit: ");
// int third = Convert.ToInt32(Console.ReadLine());

// if (IsItPositive(first, second, third) == false)
// {
//     bool result = CanTriangleBe(first, second, third);
//     Console.WriteLine($"Triangle with sides {first}, {second}, {third} can exist?");
//     Console.WriteLine(result ? "No!" : "Yes!");
// }
// else Console.WriteLine("One of you numbers < 0;");

// bool IsItPositive(int one, int two, int three)
// {
//     return one < 0 || two < 0 || three < 0;
// }

// bool CanTriangleBe(int one, int two, int three)
// {
//     return one >= (two + three) || two >= (one + three) || three >= (one + two);
// }

Console.WriteLine("1 число:  ");
int digit1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2 число:  ");
int digit2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3 число:  ");
int digit3 = Convert.ToInt32(Console.ReadLine());

bool IsItPositiveChecking(int num1, int num2, int num3)
{
    return num1 > 0 && num2 > 0 && num3 > 0;
}

bool IsExistTriangle(int num1, int num2, int num3)
{
    return num1 >= num2 + num3 || num2 >= num1 + num3 || num3 >= num1 + num2;
}

// Console.WriteLine(IsItPositiveChecking(digit1, digit2, digit3));
// IsItPositiveChecking(digit1, digit2, digit3);

if (IsItPositiveChecking(digit1, digit2, digit3))
{
    bool result = IsExistTriangle(digit1, digit2, digit3);
    Console.WriteLine(result ? "Нет" : "Да");
}
else Console.WriteLine("Ошибка ввода числа");