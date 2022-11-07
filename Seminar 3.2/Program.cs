//Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).

void CoordinateRange(int numberRange)
{
    if(numberRange == 1) System.Console.WriteLine("Диапазон координат (+Х; +Y)");
    else if(numberRange == 2) System.Console.WriteLine("Диапазон координат (-X; +Y)");
    else if(numberRange == 3) System.Console.WriteLine("Диапазон координат (-X; -Y)");
    else if(numberRange == 4) System.Console.WriteLine("Диапазон координат (+X; -Y)");
}
System.Console.WriteLine("Номер плоскости ");
int numberRange = int.Parse(System.Console.ReadLine()!);
CoordinateRange(numberRange);
