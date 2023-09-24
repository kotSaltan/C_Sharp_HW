//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a, b, c;

Console.WriteLine("Enter number A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number B: ");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number C: ");
c = Convert.ToInt32(Console.ReadLine());



if (a == b && a == c) 
{
    Console.WriteLine("A = B = C");
}
else 
{
    if (a > b && a > c) 
{
    Console.WriteLine("A is the biggest number");
}
    else if (b > a && b > c)
{
    Console.WriteLine("B is the biggest number");
}
    else if (c > a && c > b)
{
    Console.WriteLine("C is the biggest number");
}}


