// Дополнительная Задача 9
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

int MulDigit(int number)
{
    if (number % 7 == 0 && number % 23 == 0)
    {
        System.Console.Write("Кратно одновременно 7 и 23, число: ");
    }
    else
    {
        System.Console.Write("Не кратно одновременно 7 и 23, число: ");
    }
    return number;
}
int myNumber = 165;
System.Console.WriteLine(MulDigit(myNumber));

// Задача 10. Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

int GetTwoDigit(int number)
{
    int TwoDigit = (number % 100) / 10;
    return TwoDigit;
}
int myNumber = 918;
Console.WriteLine(GetTwoDigit(myNumber));

// Задача 13. Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

int GetThirdDigit(int number)
{
    if(number > 999)
    {
        while(number > 999)
        {
        number = number / 10;
        }
    }
    if(number > 99 & number < 1000)
    {
        number = number % 10;
    }
    else
    {
        System.Console.Write("Нет третьей цифры в числе: ");
    }
    return number;
}
int myNumber = 248984;
System.Console.WriteLine(GetThirdDigit(myNumber));

// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int DayWeek(int number)
{
    if (number> 0 && number < 8)
    {
        if (number == 7 || number == 6)
        {
            System.Console.WriteLine("Ура, выходной!");
        }
        else
        {
            System.Console.WriteLine("Увы, будний.");
        }
    }
    else
    {
        System.Console.WriteLine("Упс, ошибка, введите число от 1 до 7");
    }
    return number;
}
int myNumber = 8;
System.Console.WriteLine(DayWeek(myNumber));

// Не могу никак избавиться от того, чтобы на выходе программа не выдавала вводное значение.
// Попытался изначально поковырять массив, но успехом не увенчалось :(

// int[] DayWeek = {1,2,3,4,5,6,7}; 
// int n = DayWeek.Length;
// int index = 0;
// while(index < n)
// {
//     if(DayWeek[index] == 6 || DayWeek[index] == 7)
//     {
//         System.Console.WriteLine("Выходной");
//     }
//     else
//     {
//         System.Console.WriteLine("Будний");
//     }
//     index ++;
// }
// int number = 6;
// System.Console.WriteLine(DayWeek[number]);