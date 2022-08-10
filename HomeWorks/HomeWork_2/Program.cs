/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int SecondNumber(int number)
{
    number = ((number / 10) % 10);
    return number;
}
Console.Write("Введите трехзначное число ");
int n = Convert.ToInt32(Console.ReadLine());
int secondn = SecondNumber(n);
Console.WriteLine($"Вторая цифра {secondn}");
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void ThirdNumber(int number)
{ if (number > 99)
{
    while (number > 1000)
        number = number / 10;
    int newnumber = number % 10; 
    Console.WriteLine($"Третья цифра {newnumber}");  
}
     else
        Console.WriteLine($"Третьей цифры нет");
}
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
ThirdNumber(n);
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool DayOff(int number)
{
    if (number == 6 ^ number == 7)
        return true;
    else
        return false;

}
Console.WriteLine("Введите число от 1 до 7 ");
int n = Convert.ToInt32(Console.ReadLine());
bool Day = DayOff(n);
Console.WriteLine(Day);
*/