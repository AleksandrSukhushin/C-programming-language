// Семинар 2. Решение задач по теме Массивы и Функции

// Задача 2 (3). Напишите программу, которая выводит случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

int GetTheDiggestDigit(int number)
{
    int num1 = number / 10;
    int num2 = number % 10;
    if(num1 > num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}
int number = new Random().Next(10,100);
System.Console.Write("Случайное число: ");
System.Console.WriteLine(number);
System.Console.Write("Наибольшая цифра: ");
System.Console.WriteLine(GetTheDiggestDigit(number));