// Семинар 2. Решение задач по теме Массивы и Функции

// Задача 2 (2). Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

int max = new Random().Next(10,100);
System.Console.WriteLine(max);
int Get1Digit(int max)
{
    int num1 = max / 10;
    return num1;
}
int Get2Digit(int max)
{
    int num2 = max % 10;
    return num2;
}
if(Get1Digit(max) > Get2Digit(max))
System.Console.WriteLine(Get1Digit(max));
if(Get1Digit(max) <= Get2Digit(max))
System.Console.WriteLine(Get2Digit(max));