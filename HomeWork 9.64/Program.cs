// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
// промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Задайте значение n больше 1: ");
int amount = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("\nВсе натуральные числа от n до 1: ");
void NaturalNumbers (int amount)
{
    Console.Write(amount);
    if (amount == 1)
    {
        return;
    }
    System.Console.Write(", ");
    NaturalNumbers (amount - 1);
    return;
}
NaturalNumbers(amount);
