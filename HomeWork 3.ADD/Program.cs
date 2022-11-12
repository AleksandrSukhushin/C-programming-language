// // Дополнительно.
// Напишите программу, которая принимает на вход число (N) и выдает таблицу простых чисел от 1 до N.
// 11 -> 2, 3, 5 , 7, 11

bool PrimeNumbers(int number)
{
    int sqrtNumber = (int) (Math.Sqrt(number));
    for (int i = 2; i <= sqrtNumber; i++)
    {
        if (number % i == 0)
            return false;
    }
    return true;
}
int count = 0;
int maxNumber = 11;
for (int num = 2; num <= maxNumber; num++)
{
    if (PrimeNumbers(num))
    {
        count++;
        Console.Write(num.ToString()+" ");
    }
}
Console.WriteLine();
