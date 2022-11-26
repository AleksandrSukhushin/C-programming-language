// Дополнительно. Дан массив. Найдите MEX массива. MEX (Minimum EXcluded) - минимальный отсутствующий элемент.

Console.Clear();

int[] numbers = new[] {0, 2, 1, 7, 5, 3, 6};
int mex = GetMEX(numbers);
Console.WriteLine($"Минимальное целое неотрицательное число, которого нет в массиве: {mex}");
Console.ReadKey();

int GetMEX(int[] numbers)
{
    for (int mex = 0; mex < numbers.Length; mex++)
    {
        bool valueMissing = true;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == mex)
            {
                valueMissing = false;
                break;
            }
        }
        if (valueMissing){return mex;}
    }
    return numbers.Length;
}
