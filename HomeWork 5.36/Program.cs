// Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[elements];
FillArrayRndNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);

int sum = 0;
for (int i = 0; i < numbers.Length; i += 2)
{
    sum = sum + numbers[i];
}
Console.WriteLine($"Сумма чисел на нечетных позициях: {sum}");

void FillArrayRndNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0,100);
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
