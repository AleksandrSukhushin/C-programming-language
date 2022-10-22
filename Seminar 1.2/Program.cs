// Задача 2. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Решение через цикл "do - while" от Вячеслава.
// Нужно добавить условие, что если число не входит в диапазон, то на экране появится соответвующая ошибка и попросит пользователя 
// ввести число еще раз.

string[] DayWeek = new string[8];
int UserChoice;

DayWeek[1] = "Понедельник";
DayWeek[2] = "Вторник";
DayWeek[3] = "Среда";
DayWeek[4] = "Четверг";
DayWeek[5] = "Пятница";
DayWeek[6] = "Суббота";
DayWeek[7] = "Воскресенье";

do
{
    System.Console.WriteLine("Введите номер дня недели: ");
    UserChoice = int.Parse(Console.ReadLine()!);
    System.Console.WriteLine(DayWeek[UserChoice]);
}
while (UserChoice > 0 && UserChoice < 8);
