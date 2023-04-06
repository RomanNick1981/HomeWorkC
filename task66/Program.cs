// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке
int get_sum(int n, int m)
{
    int sum = 0;
    // Пока разница между n и m не станет 0
    while (n <= m)
    {
        sum += n;
        n++;
    }
    return sum;
}

Console.Clear();
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(get_sum(n, m));