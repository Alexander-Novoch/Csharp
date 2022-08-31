using System;

Console.WriteLine("Введите первое число");

string input1 = Console.ReadLine();

int number1 = int.Parse(input1);

Console.WriteLine("Введите второе число");

string input2 = Console.ReadLine();

int number2 = int.Parse(input2);

if (number1 > number2)
{
    Console.Write("MAX->");
    Console.Write(number1);
}
else
{
    Console.Write("MAX->");
    Console.Write(number2);
}
