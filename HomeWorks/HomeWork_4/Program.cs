// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Power(int n1, int n2)
{
    int i = 0;
    int result = 0;
    while( i <= n2)
        result = result + n1 * n1;
        i++;
    return result;

}

Console.WriteLine("Введите два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int res = Power(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} равно {res}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.




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