/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;
if (number1 < number2)
    Console.WriteLine($"max is {number2}, min is {number1}");
else
    Console.WriteLine($"max is {number1}, min is {number2}");
*/

/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    Console.Write("Input first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > max)
    max = number2;
if (number3 > max)
    Console.WriteLine($"max is {number3}");
else
    Console.WriteLine($"max is {max}");
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Input integer number ");
int number = Convert.ToInt32(Console.ReadLine());
int rem = number % 2;
if (rem == 0)
    Console.WriteLine($"{number} is even numder");
else
    Console.WriteLine($"{number} is odd numder");
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Input integer number ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= number)
{
    if (current % 2 == 0)
        Console.Write($"{current} ");
    current++;
}
*/
