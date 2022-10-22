// Домашнее задание 1

// Задача 6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным 
// (делится ли оно на два без остатка).

Console.WriteLine("Введите num1");
int num1 = int.Parse(Console.ReadLine()!);
if (num1 % 2 == 0)
{
    System.Console.WriteLine($"{num1} => четное");
}
else
{
    System.Console.WriteLine($"{num1} => нечетное");
}