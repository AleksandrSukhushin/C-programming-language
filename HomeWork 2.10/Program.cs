// Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int GetLastDigit(int number)
{
    int LastDigit = number / 10;
    return LastDigit;
}
int GetTwoDigit(int number)
{
    int TwoDigit = number % 10;
    return TwoDigit;
}
int testNumber = 456;
Console.WriteLine(GetTwoDigit(testNumber));