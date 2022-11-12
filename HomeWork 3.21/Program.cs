//Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int aX = ReadInt("Введите координату aX: ");
int aY = ReadInt("Введите координату aY: ");
int aZ = ReadInt("Введите координату aZ: ");
int bX = ReadInt("Введите координату bX: ");
int bY = ReadInt("Введите координату bY: ");
int bZ = ReadInt("Введите координату bZ: ");

int A = bX - aX;
int B = bY - aY;
int C = aZ - bZ;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
