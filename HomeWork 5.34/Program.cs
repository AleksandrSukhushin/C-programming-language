// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear(); // у кого-то на семинаре увидел, показалось, что прикольная штука, взял на вооружение)

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[elements];
FillArrayRndPosThreeDigNum(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0) count++;
}
Console.WriteLine($"Количество четных чисел: {count}");

void FillArrayRndPosThreeDigNum(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
