// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int n, int m)
{
    if(m!=n)
    {
        if(n>m)
        {
            ShowNumbers(n-1,m);
            Console.Write(n +" ");
        }
        else
        {
            ShowNumbers(m-1,n);
            Console.Write(m +" ");
        }
    }
    else
        Console.Write(m +" ");
 }
 ShowNumbers(4, 33);
*/
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum(int n, int m)
{
    if(m == n)
        return n;
    return m + FindSum(n, m - 1);
}
Console.WriteLine(FindSum(1,15));
*/

// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
/*
int recursion(int m, int n)
{
    if (m == 0)
        return n + 1;
    else 
    {
        if (n == 0 && m > 0) 
            return recursion(m - 1, 1);
        else
            return recursion(m - 1, recursion(m, n - 1));
    }
}
Console.WriteLine(recursion(3,2));
*/