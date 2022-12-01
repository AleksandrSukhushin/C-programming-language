// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

Console.Write("Введите число m больше 0: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите число n больше 0: ");
int n = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"Значение функции Аккермана А(m,n): {Function(m,n)}");

int Function(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Function(m - 1, 1);
    }
    else
    {
        return (Function(m - 1, Function(m, n - 1)));
    }
}
