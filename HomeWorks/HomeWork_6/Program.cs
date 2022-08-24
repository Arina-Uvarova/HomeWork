// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for(int i = 0; i<size; i++)
    {
        Console.WriteLine("Введите элемент массива ");
        newArray[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void CountOfPositive(int[] Array)
{
    int count = 0;
    for(int i = 0; i < Array.Length; i++)
        if(Array[i] > 0)
            count += 1;
    Console.WriteLine($"Количество положительных чисел равно {count}");
}
Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(n);
ShowArray(myArray);
CountOfPositive(myArray);
*/

// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
void FindPoint (double k1, double k2, double b1, double b2)
{
    if(k1 == k2 && b1 == b2)
        Console.WriteLine("Прямые совпадают");
    if(k1 == k2)
        Console.WriteLine("Прямые параллельны");
    double x = (b2 - b1)/(k1 - k2);
    double y = (k1 * (b2 - b1))/(k1 - k2) + b1;
    Console.WriteLine($"Точка пересечения равна {x},{y}");
}
Console.WriteLine("Введите k1 ");
double a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2 ");
double a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1 ");
double c1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2 ");
double c2 = Convert.ToInt32(Console.ReadLine());
FindPoint(a1, a2, c1,c2);
*/