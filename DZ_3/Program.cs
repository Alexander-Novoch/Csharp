using System;

Console.WriteLine("Введите число");

string input1 = Console.ReadLine();

int number1 = int.Parse(input1);

int ostatok = number1 % 2;

if (ostatok > 0)
    Console.Write("Это нечётное число");
else
    Console.Write("Это чётное число");
