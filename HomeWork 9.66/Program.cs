// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Задайте значение m больше 0: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Задайте значение n больше 0: ");
int n = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write($"\nСумма всех натуральных чисел от {m} до {n}: {SumNaturalNumbers(m, n)}");

int SumNaturalNumbers (int m, int n)
{
    if (m == n)
    {
        return n;
    }
    return n + SumNaturalNumbers (m, n - 1);
}
