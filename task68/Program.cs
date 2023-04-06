// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n
int akkerman_func(int m, int n)
{
    // Если n стала нулем вернем значение
    if (m == 0) return n + 1;
    // Если n ещё не дошла до 0, уходим в рекурсию с n-1 и m=1
    if (m > 0 && n == 0) return akkerman_func(m - 1, 1);
    // Если оба не нулевые, заходим в две рекурсии с n-1 и результатом рекурсии n, m-1
    if (m > 0 && n > 0) return akkerman_func(m - 1, akkerman_func(m, n - 1));
    // По сути, заглушка на случай отрицательного n
    return -1;
}

Console.Clear();
int n = -1, m = -1;
while (m < 0)
{
    Console.WriteLine("Введите неотрицательное M");
    m = Convert.ToInt32(Console.ReadLine());
}
while (n < 0)
{
    Console.WriteLine("Введите неотрицательное N");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(akkerman_func(m, n));