//Task 10
Console.Clear();
Console.WriteLine("Введите трёзначное число: \n");
int a = Convert.ToInt32(Console.ReadLine());
while (a > 999 || a < 100)
{
    Console.WriteLine("Ошибка, введите трёзначное число");
    a = Convert.ToInt32(Console.ReadLine());
}
a /= 10;
a %= 10;
Console.WriteLine($"Ответ {a}\n");
