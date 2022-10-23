// Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int GetTwoDigit(int number)
{
    int TwoDigit = (number % 100) / 10;
    return TwoDigit;
}
int myNumber = 456;
Console.WriteLine(GetTwoDigit(myNumber));