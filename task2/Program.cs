﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3


int a, b;

Console.WriteLine("Enter number A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B: ");
b = Convert.ToInt32(Console.ReadLine());




if (a == b) 
{
    Console.WriteLine("A = B");
}
else 
{
    if (a > b) 
{
    Console.WriteLine("A > B");
}
else 
{
    Console.WriteLine("B > A");
}
}
