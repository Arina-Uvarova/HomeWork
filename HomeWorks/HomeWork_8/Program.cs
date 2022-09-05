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
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 10);
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
    int i = 0;
    for(int j = 0; j < array.GetLength(1); j++)
        {
            a = a + array[i,j];
        }
    sum = a;
    a = 0;
    for(int y = 1; y < array.GetLength(0); y++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            a = a + array[y,j];
        }
        if(a < sum)
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
*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int columns)
{
    int[,] newArray = new int [rows, columns];
    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(1, 100);
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

int[,] Multiplication(int[,] array_1, int[,] array_2)
{
    int[,] result = new int[array_1.GetLength(0), array_2.GetLength(1)];
    for (int i = 0; i < array_1.GetLength(0); ++i)
        for (int j = 0; j < array_2.GetLength(0); ++j)
            for (int k = 0; k < array_2.GetLength(1); ++k)
                result[i, k] += array_1[i, j] * array_2[j, k];
    return result;
}     


Console.WriteLine("Введите количество строк матрицы 1 ");
int m1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов матрицы 1 ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк матрицы 2 ");
int m2 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите количество столбцов матрицы 2 ");
int n2 = Convert.ToInt32(Console.ReadLine());

int [,] myArray1 = CreateRandom2dArray(m1,n1);
int [,] myArray2 = CreateRandom2dArray(m2, n2);
Show2dArray(myArray1);
Console.WriteLine();
Show2dArray(myArray2);
Console.WriteLine();
int[,] Multi = Multiplication(myArray1, myArray2);
Show2dArray(Multi); 
*/

// Напишите программу, которая заполнит спирально массив 
/*
void Spiral(int[,] arr)
{
    int n = arr.GetLength(0);
    int count = n;
    int value = -n;
    int sum = -1;
    do
    {
        value = -1 * value / n;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            Console.Write(arr[sum / n, sum % n] + " ");
         }
        value *= n;
        count--;
        for (int i = 0; i < count; i++)
        {
            sum += value;
            Console.Write(arr[sum / n, sum % n] + " ");
        }
    } while (count > 0);
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

Spiral(new int[4,4]);
Show2dArray(new int[4,4]);
*/

namespace cyber1 {
    class Program {
        static void Main() {
            Console.Write(" n = ");
            int N = Convert.ToInt32(Console.ReadLine());//границы снизу и сверху
            Console.Write(" m = ");
            int M = Convert.ToInt32(Console.ReadLine());//границы слева и спава
           
 
            int[,] MM = new int[N, M];            
            int row = 0, col = 0, dx = 0, dy = 1, dirChanges = 0, gran = N;
            int l =  MM.Length;
            for(int i = 0; i < l; i++) {
                MM[row, col] = i + 1;
 
                if(--gran == 0) {
                    gran = N * (dirChanges % 2) + M * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dy;
                    dy = -dx;
                    dx = temp;
                    dirChanges++;
                }
 
                col += dx;
                row += dy;
            }
                        
            M = MM.GetLength(1);
            for(int k = 0; k < l; k++)
                Console.Write("{0}{1,3}", k % M == 0 ? "\n" : "", MM[k / M, k % M]);
 
 
            Console.ReadLine();
        }
    }
}