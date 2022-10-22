// Итерация №1
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.

Console.WriteLine("Введите num1");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите num2");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 < num2)
{
    if(num2 == num1 * num1)
    {
        Console.WriteLine($"Да, {num2} является квадратом {num1}");
    }
    else
    {
        Console.WriteLine($"Нет, {num2} не является квадратом {num1}");
    }
}
else
{
    System.Console.WriteLine($"Внимание, должно соблюдаться условие num1 < num2!");
}