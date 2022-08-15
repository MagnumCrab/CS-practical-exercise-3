//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int aX, aY, aZ;
int bX, bY, bZ;

Console.WriteLine("Поочередно введите координаты двух точек (a и b) в трёхмерном пространстве: ");
Console.Write("aX: ");
aX = Convert.ToInt32(Console.ReadLine());
Console.Write("aY: ");
aY = Convert.ToInt32(Console.ReadLine());
Console.Write("aZ: ");
aZ = Convert.ToInt32(Console.ReadLine());

Console.Write("bX: ");
bX = Convert.ToInt32(Console.ReadLine());
Console.Write("bY: ");
bY = Convert.ToInt32(Console.ReadLine());
Console.Write("bZ: ");
bZ = Convert.ToInt32(Console.ReadLine());

double resultDoub;
resultDoub = Math.Pow(bX - aX, 2) + Math.Pow(bY - aY, 2) + Math.Pow(bZ - aZ, 2);
resultDoub = Math.Sqrt(resultDoub);
resultDoub = Math.Round(resultDoub, 2);

Console.WriteLine($"Расстояние между точками: {resultDoub}");