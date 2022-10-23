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
