// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
// значение этого элемента или же указание, что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

Console.Write("Номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Номер столбца: ");
int cols = Convert.ToInt32(Console.ReadLine());

int [,] massive = new int [3,4];
FillArray(massive);

if (rows > massive.GetLength(0) || cols > massive.GetLength(1))
{
    Console.WriteLine("В заданной позиции элемент в массиве не найден");
}
else
{
    Console.WriteLine($"В заданной позиции элемент в массиве равен: {massive[rows - 1,cols - 1]}");
}
PrintArray(massive);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i, j] = new Random().Next(0, 10);
            }
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine(" ");
    }
}
