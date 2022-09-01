// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] newArray = new double [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = (maxValue + 1 - minValue) * new Random().NextDouble() + minValue;
    return newArray;
}

void Show2dArray(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальную позицию ");
double min = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите максимальную позицию ");
double max = Convert.ToInt32(Console.ReadLine());
double [,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 1000);
    return newArray;
}

void FindPoint(int[,] array, int a, int b)
{
    int c = array.GetLength(0);
    int d = array.GetLength(1);
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(a == i && b == j)
                Console.WriteLine($"Элемент равен {array[i,j]}");
        }
    }
    if(a > c | b > d)
        Console.WriteLine("Такого элемента нет");
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение массива ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение массива ");
int num2 = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
FindPoint(myArray, num1, num2);
*/



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 100);
    return newArray;
}

void FindPoint(int[,] array)
{
    double avg = 0;
    int a = array.GetLength(0);
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
           avg = avg + array[j,i];
        }
        avg = avg / a;
        Console.Write($"Среднее арифметическое равно {avg} ");
        Console.WriteLine("");
        avg = 0;

    }
}

void Show2dArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");
        Console.WriteLine();
    }
}
Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
FindPoint(myArray);
*/