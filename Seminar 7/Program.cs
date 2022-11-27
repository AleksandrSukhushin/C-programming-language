// Семинар 7

// Задача 46. Задайте двумерный массив размером, заполненный случайными числами

// Console.Clear();

// int[,] array = GetArrayRandom(3, 4);
// PrintArray(array);

// int[,] GetArrayRandom(int rows, int cols, int minValue = 0, int maxValue = 1000)
// {
//     int[,] array = new int[rows, cols];

//     var rnd = new Random();

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = rnd.Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// Задача 48. Задайте двумерный массив mxn, каждый элемент которого находится по формуле: A=m+n.
// Выведите полученный массив на экран.

// int[,] Array(int m, int n)
// {
//     int[,] newArray = new int[m, n];
//     for (int i = 0; i < newArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < newArray.GetLength(1); j++)
//         {
//             newArray[i, j] = i + j;
//         }
//     }
//     return newArray;
// }
// void PrintArray(int[,] myArray)
// {
//     for (int i = 0; i < myArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < myArray.GetLength(1); i++)
//         {
//             System.Console.WriteLine(myArray[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }
// PrintArray(Array);

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

Console.Clear();
