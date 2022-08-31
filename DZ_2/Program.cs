using System;

Console.WriteLine("Введите первое число");

string input1 = Console.ReadLine();

int number1 = int.Parse(input1);

Console.WriteLine("Введите второе число");

string input2 = Console.ReadLine();

int number2 = int.Parse(input2);

Console.WriteLine("Введите третье число");

string input3 = Console.ReadLine();

int number3 = int.Parse(input3);

if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.Write("MAX->");
        Console.Write(number1);
    }

    else 
    {
        Console.Write("MAX->");
        Console.Write(number3);

    }
}
else if (number2 > number3)
    {
        Console.Write("MAX->");
        Console.Write(number2);
    }
else
{
    Console.Write("MAX->");
    Console.Write(number3);
}
