// Домашнее задание 1
// Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите num1");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите num2");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 > num2)
{
    Console.WriteLine($"{num1} => max, {num2} => min");
}
else
{
    Console.WriteLine($"{num2} => max, {num1} => min");
}