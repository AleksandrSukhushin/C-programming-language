// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

System.Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstArray = new int[rows, cols];
int[,] secondArray = new int[rows, cols];
int[,] resultingArray = new int[rows, cols];

FillArray(firstArray);
PrintArray(firstArray);
Console.WriteLine();
FillArray(secondArray);
PrintArray(secondArray);
Console.WriteLine();


if (firstArray.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Количество строк должно быть равно количеству столбцов");
    return;
}

for (int i = 0; i < firstArray.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultingArray[i, j] = 0;
        for (int k = 0; k < firstArray.GetLength(1); k++)
        {
            resultingArray[i, j] += firstArray[i, k] * secondArray[k, j];
        }
    }
}
PrintArray(resultingArray);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
