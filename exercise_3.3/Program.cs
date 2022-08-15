//Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

int number;
Console.Write("Введите любое число: ");
number = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= number; i++) Console.Write($"{Math.Pow(i, 3)} ");
Console.WriteLine(" ");