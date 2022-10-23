// Семинар 2. Решение задач по теме Массивы и Функции

// Задача 1. Напишите программу, которая принимает на вход трехзначное число 
//и на выходе показывает последнюю цифру этого числа.

int GetLastDigit(int number)
{
    //int lastDigit = number % 10;
    // Можно просто: return number % 10 без верхней строчки;
    //return lastDigit;
    return number % 10;
}
int testNumber = 5123235;
//int lastDigit = GetLastDigit(testNumber);

Console.WriteLine(GetLastDigit(testNumber));