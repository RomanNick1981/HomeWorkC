// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке
int f(int m, int n)
{
    if (m == n)
        return m;
    return f(m, n - 1) + n;
}

Console.Clear();
System.Console.Write("Введите начальное число: ");
int m = int.Parse(Console.ReadLine()!);
System.Console.Write("Введите конечное число: ");
int n = int.Parse(Console.ReadLine()!);
System.Console.WriteLine(f(m, n));