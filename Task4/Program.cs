// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.Clear();
Console.Write("Введите 3 числа для сравнения:\n ");
Console.Write("Введите 1-е число для сравнения: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите 2-е число для сравнения: ");
int b = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите 3-е число для сравнения: ");
int c = Convert.ToInt32(Console.ReadLine()!);
if (a > b) b=a;
if (b>c) c=b;
Console.Write("Результат число " + c + " - Максимальное\n ");