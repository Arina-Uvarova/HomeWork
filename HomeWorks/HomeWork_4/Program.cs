// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Power(int n1, int n2)
{
    int result = 1; 
    int i =1;
    while(i <= n2)
        {
        result = result * n1;
        i++;
    }  
    return result;

}

Console.WriteLine("Введите два числа ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int res = Power(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} равно {res}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum (int number)
{
    int sum = 0;
    while(number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
Console.Write("Введите целое число ");
int a = Convert.ToInt32(Console.ReadLine());
int result = Sum(a);
Console.WriteLine($"Сумма цифр {a} равна {result} ");
*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(n);
ShowArray(myArray);
*/



