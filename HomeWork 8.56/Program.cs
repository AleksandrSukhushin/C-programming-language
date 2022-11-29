// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

int[,] array = new int[,] {{1, 4, 7, 2},
                           {5, 9, 2, 3},
                           {8, 4, 2, 4},
                           {5, 2, 6, 7}};
Console.WriteLine("Исходный массив:\n");
PrintArray(array);

int minSumRow = 0;
int sumRow = SumRowElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int temp = SumRowElements(array, i);
  if (sumRow > temp)
  {
    sumRow = temp;
    minSumRow = i;
  }
}
Console.WriteLine($"\nОтвет: {minSumRow+1} строкa с наименьшей суммой элементов, равной {sumRow}. \n");

int SumRowElements(int[,] array, int i)
{
  int sumRow = array[i, 0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i, j];
  }
  return sumRow;
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
