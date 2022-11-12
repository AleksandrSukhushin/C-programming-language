// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Если честно, немного не понял условие задачи, наверное число "8" указано некорректно.
// Представленный ниже вариант решения подходит для вывода радномного массива чисел, соответствующего его длине.

// int lengthArray = ReadInt("Введите длинну массива: ");
// int[] randomArray = new int[lengthArray];
// for (int i = 0; i < randomArray.Length; i++)
// {
//     randomArray[i] = new Random().Next(1,9);
//     Console.Write(randomArray[i] + " ");
// }
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

Console.WriteLine("Введите количество элементов массива: ");
int elementsNumber = int.Parse(Console.ReadLine()!);
int[] myArray = new int[elementsNumber];
for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите элемент массива под индексом {i}: ");
    myArray[i] = int.Parse(System.Console.ReadLine()!);
}
Console.WriteLine("Массив: ");
