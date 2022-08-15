/*
// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
bool Check(int n)
{
    int current = 10000;
    int result = 0;
    int n1 = n;
    while(current > 0)
    {
        int a = n1 % 10;
        n1 = n1 /10;
        result = a * current + result;
        current = current / 10;
    }
    Console.WriteLine(result);
    if(n == result)
        return true;
    else
        return false;
}
Console.WriteLine("Введите пятизначное число ");
int number = Convert.ToInt32(Console.ReadLine());
bool check = Check(number);
Console.WriteLine(check);

*/

/*
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double FindLength(double x1,double y1, double z1, double x2, double y2, double z2)
{
    double len = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
    return len;
}
Console.WriteLine("Введите координаты точки A ");
double xA = Convert.ToInt32(Console.ReadLine());
double yA = Convert.ToInt32(Console.ReadLine());
double zA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B ");
double xB = Convert.ToInt32(Console.ReadLine());
double yB = Convert.ToInt32(Console.ReadLine());
double zB = Convert.ToInt32(Console.ReadLine());

double length = FindLength(xA, yA, zA, xB, yB, zB);
Console.WriteLine($"Расстояние между точками A и B равно {length}");
*/

/*
// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void ShowCube(int n)
{
    int current = 1;
    while (current <= n)
    {
        int current1 = current * current * current;
        Console.Write($"{current1} ");
        current++;
    }
}
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
ShowCube(number);
*/