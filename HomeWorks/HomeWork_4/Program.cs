// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
double Power(int a, int b)
{
    double result = Math.Pow(a, b);
    return result;
}

Console.WriteLine("Введите два числа ");
int n1 = Convert.ToInt32(Console.ReadLine());
int n2 = Convert.ToInt32(Console.ReadLine());
double res = Power(n1, n2);
Console.WriteLine($"Число {n1} в степени {n2} равно {res}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum(int number)
{
    char[] arr = number.ToString().ToCharArray();
    int count = arr.Length;
    int result = 0;
    for(int i = 0; i <= count ; i++)
        result = result + arr[i];
    return result;
}
Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());
int res = Sum(n);
Console.WriteLine($"Сумма цифр числа {n} равна {res}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for(int i = 0; i<size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i=0; i < array.Length; i++)
    Console.Write(array[i] + " ");
Console.WriteLine();
}
Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальную позицию ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальную позицию ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(n, min, max);
Console.WriteLine($"Ваш массив - {myArray}");
ShowArray(myArray);
*/