// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void IsPalindromName(int number)
{
    if(number >= 10000)
    {
        int num1 = number / 10000;
        int res1 = number % 10;
            if(num1 == res1)
            {
                number = number / 10;
                int num2 = (number / 100) % 10;
                int res2 = number % 10;
                if(num2 == res2)
                    Console.WriteLine("It's a palindrome");
            }
            else
            Console.WriteLine("It's not a palindrome");
    }
    else
    Console.WriteLine("Необходимо пятизначное число!");
}

Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
IsPalindromName(number);
