// Домашнее задание 1

// Задача 4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите num1");
int num1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите num2");
int num2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите num3");
int num3 = int.Parse(Console.ReadLine()!);

if(num1 > num2 &&  num2 > num3)
{
    Console.WriteLine($"{num1} => max из ряда чисел: {num1}, {num2}, {num3}");
}

if(num1 < num2 && num2 > num3)
{
    Console.WriteLine($"{num2} => max из ряда чисел: {num1}, {num2}, {num3}");
}

if(num1 < num2 && num2 < num3)
{
    Console.WriteLine($"{num3} => max из ряда чисел: {num1}, {num2}, {num3}");
}