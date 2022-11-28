// Pадача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы
// каждой строки двумерного массива.

Console.Clear();

Console.Write("Количество строк: ");
int rowsAmount = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов: ");
int colsAmount = Convert.ToInt32(Console.ReadLine());

int[,] massive = new int[rowsAmount, colsAmount];
FillArray(massive);
Console.WriteLine();
PrintArray(massive);

int rows = massive.GetLength(0);
int cols = massive.GetLength(1);
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols - 1; j++)
    {
        for (int k = 0; k < cols - 1; k++)
        {
            if (massive[i, k] < massive[i, k + 1])
            {
                int temp = 0;
                temp = massive[i, k];
                massive[i, k] = massive[i, k + 1];
                massive[i, k + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(massive);

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
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
