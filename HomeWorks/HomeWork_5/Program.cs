// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateRandomArray(int size)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
void CountEnenNumbers(int [] NewArray)
{
    int count = 0;
    for(int i = 0; i < NewArray.Length; i++)
    {
        if(NewArray[i]%2 == 0)
            count += 1;
    }
    Console.WriteLine($"Количество четных чисел равно {count}");
}

Console.Write("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a);
ShowArray(myArray);
CountEnenNumbers(myArray);
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

void FindSum(int [] NewArray)
{
    int count = 0;
    for(int i = 0; i < NewArray.Length; i++)
    {
        if(i % 2 == 1)
            count += NewArray[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {count}");
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную позицию ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную позицию ");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateRandomArray(a, min, max);
ShowArray(MyArray);
FindSum(MyArray);
*/
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
int[] CreateArray(int size, int minValue, int maxValue)
{
    int [] NewArray = new int[size];
    for(int i = 0; i < size; i++)
        NewArray[i] = new Random().Next(minValue, maxValue +1);
        return NewArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindResult(int[] ThirdArray)
{
    int i = 0;
    int min = ThirdArray[i];
    int max = ThirdArray[i + 1];
    for(i = 0; i < ThirdArray.Length; i++)
        if(ThirdArray[i] < min)
            min = ThirdArray[i];
            Console.WriteLine($"Минимальный элемент массива равен {min}");    
    for(i = 0; i < ThirdArray.Length; i++)
        if(ThirdArray[i] > max)
            max = ThirdArray[i];
            Console.WriteLine($"Максимальный элемент массива равен {max}");  
    int result = max - min;
    return result;  
}

Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальную позицию ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальную позицию ");
int max = Convert.ToInt32(Console.ReadLine());

int[] MyArray = CreateArray(a, min, max);
ShowArray(MyArray);
int res = FindResult(MyArray);
Console.WriteLine($"Разница между макс и мин значениями массива равна {res}");    

*/
