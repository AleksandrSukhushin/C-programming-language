// ДОП. Дан массив чисел. Напишите функцию, которая ищет заданное число в массиве и показывает нужный индекс в нем.
// При отсутствии числа возвращать -1.

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[elements];
FillArrayRndNumbers(numbers);
Console.Write("Исходный массив: ");
PrintArray(numbers);
Console.Write("Введите искомое значение: ");
int value = Convert.ToInt32(Console.ReadLine());

int index = 0;
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if(numbers[i] == value)
        {
            index = i;
            break; // Долго мучался не понимая, почему всегда выдает индекс "-1", но потом вспомнил и понял, в чем проблема)
        }
        else
        {
            index = -1;
        }
    }
}

Console.WriteLine($"Индекс искомого значения: {index}");

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
