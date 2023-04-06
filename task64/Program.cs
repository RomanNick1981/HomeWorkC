// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Task 64
int print_naturals(int n)
{
    // Пока n не дошла до 1
    if (n > 1)
    {
        Console.Write(n.ToString() + ", ");
        // Уходим дальше в рекурсию, отняв единицу
        return print_naturals(n - 1);
    }
    // Когда n дошла до 1 вернём её
    return n;
}

Console.Clear();
Console.WriteLine("Введите натуральное число");

int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(print_naturals(a));
