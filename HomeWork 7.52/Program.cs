// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.Например,
// задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

Console.Write("Количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] massive = new int[rows, cols];
FillArray(massive);

Console.Write("Среднее арифметическое столбцов: ");
for (int j = 0; j < massive.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        avarage = (avarage + massive[i, j]);
    }
    avarage = avarage / rows;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray(massive);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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
        Console.WriteLine("");
    }
}
