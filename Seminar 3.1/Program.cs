// Семинар 3. Массивы и функции

// Задача 17
// Напишите программу, которая принимаем на вход координаты точки (X,Y), причет X и Y не равны нулю и выдает номер
//четверти плоскости, в которой находится эта точка.

int GetNumberOfPlane(int x, int y)
{
    if (x == 0 || y == 0) return -1;

    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    else return -1;
}

int x = -19, y = 20;
System.Console.WriteLine($"Номер плоскости: {GetNumberOfPlane(x, y)}");
