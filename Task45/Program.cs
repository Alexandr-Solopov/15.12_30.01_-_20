/*
Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.
*/

int[] CreateInitArrey(int size, int min, int max)
{
    int[] mas = new int[size];
    var rnd = new Random();
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(min, max);
    }
    return mas;
}
void PrintMas(int[] mas)
{
    Console.Write("[");
    for (int i = 0; i < mas.Length; i++)
    {
        if (i < mas.Length - 1) Console.Write(mas[i] + ", ");
        else System.Console.Write(mas[i]);
    }
    Console.Write("]");
}
int[] CopyMas(int[] mas)
{
    int[] tempMas = new int[mas.Length];
    for (int i = 0; i < mas.Length; i++)
    {
        tempMas[i] = mas[i];
    }
    return tempMas;
}






// int size = 5;
// int[] array1 = CreateArray(size);
// PrintArray(array1);
// int[] arraySecond = CopyArray(array1);
// PrintArray(arraySecond);

// /*Проверка
// Console.WriteLine(String.Empty);
// array1[0] = 3;
// arraySecond[0] = 5;
// PrintArray(array1);
// PrintArray(arraySecond);*/

// int[] CreateArray(int length)
// {
//     int[] array = new int[length];
//     Random rnd = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(-100, 101);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.WriteLine(arr[arr.Length - 1]);
//     }
//     Console.WriteLine(String.Empty);
// }

// int[] CopyArray(int[] arr2)
// {
//     int[] array2 = new int[arr2.Length];
//     for (int i = 0; i < arr2.Length; i++)
//     {
//         array2[i] = arr2[i];
//     }
//     return array2;
// }

// int[] arrayOrigin = CreateArrayRndInt(10, -3, 5);
// int[] arrayCopy = CopyArray(arrayOrigin);
// //arrayCopy[0] = 30;
// PrintArray(arrayOrigin);
// PrintArray(arrayCopy);
// int[] CopyArray(int[] arr)
// {
//     int[] result = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         result[i] = arr[i];
//     }
//     return result;
// }
// int[] CreateArrayRndInt(int size, int min, int max)
// {
//     int[] newArray = new int[size];
//     var rnd = new Random();
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = rnd.Next(min, max + 1);
//     }
//     return newArray;
// }
// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write(arr[i] + ",");
//         else Console.Write(arr[i]);
//     }
//     Console.WriteLine("]");
// }