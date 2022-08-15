//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number)
{
  if (number[0] == number[4] || number[1] == number[3])
  {
    Console.WriteLine($"Заданное число: {number} - является палиндром.");
  }
  else Console.WriteLine($"Заданное число: {number} - не является палиндромом.");
}

if (number!.Length == 5)
{
  CheckingNumber(number);
}
else Console.WriteLine($"Введено не пятизначное число");