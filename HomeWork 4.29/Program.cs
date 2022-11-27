// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.WriteLine("Введите количество элементов массива: ");
int elementsNumber = int.Parse(Console.ReadLine()!);
int[] myArray = new int[elementsNumber];
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    myArray[i] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine(string.Join(",", myArray));
