// Задача 33: Задайте массив. Напишите программу, 
// которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6,7,19,345,3] -> нет
// 3; массив [6,7,19,345,3] -> да

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);

bool GetNumInArray(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == num)
        return true; //правда
    }
    return false; //ложь
}

Console.Write("Введите число, которое хотите найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
bool getNumInArray = GetNumInArray(array, number);
if (getNumInArray)
{
    Console.Write($"Число {number} есть в массиве: ");
    PrintArray(array);
}
else
{
    Console.Write($"Числа {number} нет в массиве ");
    PrintArray(array);
}

void PrintArray (int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write(arr[i] + ",");
    }
    Console.WriteLine("]");
}