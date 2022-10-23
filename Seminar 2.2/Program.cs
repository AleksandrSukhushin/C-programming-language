// Семинар 2. Решение задач по теме Массивы и Функции

// Задача 2 (1). Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

int BiggerDigit(int digit)
{
    int result = -1;
    int num1 = digit % 10;
    int num2 = digit / 10;
    if(num1 > num2)
    {
        result = num1;
    } 
    else if(num2 > num1)
    {
        result = num2;
    }
    return result;
}
int randomDigit = new Random().Next(10,100);
System.Console.WriteLine(randomDigit);
System.Console.WriteLine(BiggerDigit(randomDigit));