// Задача 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

int NumberDayWeek(int number)
{
        if (number > 5 && number < 7)
        {
            System.Console.WriteLine("Выходной день :)");
        }
        else
        {
            System.Console.WriteLine("К сожалению, будний :(");
        }
    return number;
}
int myNumber = 62;
System.Console.WriteLine(NumberDayWeek(myNumber));


//System.Console.WriteLine("Введите номер дня недели от 1 до 7");



// string[] DayWeek = new string[8];
// int UserChoice;

// DayWeek[1] = "Будний день";
// DayWeek[2] = "Будний день";
// DayWeek[3] = "Будний день";
// DayWeek[4] = "Будний день";
// DayWeek[5] = "Будний день";
// DayWeek[6] = "Выходной день";
// DayWeek[7] = "Выходной день";

// do
// {
//     System.Console.WriteLine("Введите номер дня недели: ");
//     UserChoice = int.Parse(Console.ReadLine()!);
//     System.Console.WriteLine(DayWeek[UserChoice]);
// }
// while (UserChoice > 0 && UserChoice < 8);

