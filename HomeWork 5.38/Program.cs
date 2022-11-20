// Задача 38. Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[elements];
FillArrayRandomRealNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max){max = numbers[i];}
    if (numbers[i] < min){min = numbers[i];}
}

Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");

void FillArrayRandomRealNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(10,100)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + "  ");
        }
    Console.WriteLine();
}
