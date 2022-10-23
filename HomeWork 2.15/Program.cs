// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.


/* Версия преподавателя через массив:
// string[] dayWeek = {"будний","будний","будний","будний","будний","выходной","выходной"};
// int day = 7;
// Console.WriteLine($"День с номером{day}: {dayWeek[day-1]}");


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
