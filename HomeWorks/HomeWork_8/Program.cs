//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 50);
    return newArray;
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

void Sorting(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(1) - 1; k++)
        if (array[i, k] < array[i, k + 1])
        {
          int a = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = a;
        }
}
    
Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
Sorting(myArray);
Console.WriteLine();
Show2dArray(myArray);
*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 5);
    return newArray;
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

void MinSum(int[,] array)
{
    int a = 0;
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            a = a + array[i,j];
        }
        sum = a;
        if(a > sum)
            sum = a;
        a = 0;
    }

    Console.WriteLine($"{sum}");
}

Console.WriteLine("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateRandom2dArray(m,n);
Show2dArray(myArray);
MinSum(myArray);







// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



// Напишите программу, которая заполнит спирально массив 4 на 4.
