/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
//A
Console.Clear();
Console.WriteLine("Введите коардинаты X,Y,Z для точки A");
Console.Write("Введите коардинаты X:");
double ax = double.Parse(Console.ReadLine()!);
Console.Write("Введите коардинаты Y:");
double ay = double.Parse(Console.ReadLine()!);
Console.Write("Введите коардинаты Z:");
double az = double.Parse(Console.ReadLine()!);
//B
Console.WriteLine("Введите коардинаты X,Y,Z для точки B");
Console.Write("Введите коардинаты X:");
double bx = double.Parse(Console.ReadLine()!);
Console.Write("Введите коардинаты Y:");
double by = double.Parse(Console.ReadLine()!);
Console.Write("Введите коардинаты Z:");
double bz = double.Parse(Console.ReadLine()!);
//Вывод
double length = Math.Sqrt(Math.Pow(ax-bx, 2) + Math.Pow(ay-by, 2) + Math.Pow(az-bz, 2));
Console.WriteLine($"Длина отрезка равна = {Math.Round(length, 2)}");