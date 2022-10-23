// Семинар 2. Решение задач по теме Массивы и Функции

// Задача 1. Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает последнюю цифру этого числа.

int GetLastDigit(int number);
{
    int lastDigit = number % 10;
    return lastDigit;
}
int testNumber = 5123;
int lastDigit = GetLastDigit(testNumber);

System.Console.WriteLine();