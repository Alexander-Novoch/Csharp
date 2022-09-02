using System;

Console.WriteLine("Введите число от 2 до бесконечности");

string input1 = Console.ReadLine();
int number = int.Parse(input1);

if (number < 2)
    Console.Write("Неправильное число");
else
    for (int i = 2; i <= number; i = i + 2)
        Console.Write($"{i},");
