// Задание 2 
Console.Clear();
Console.Write("Введите 2 числа для сравнения:\n ");
Console.Write("Введите 1-е число для сравнения: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите 2-е число для сравнения: ");
int b = Convert.ToInt32(Console.ReadLine()!);
if (a > b) {
    Console.Write("Результат число " + a + " - Максимальное\n ");
    Console.Write("Результат число " + b + " - Минимальное\n ");
}
else {
    Console.Write("Результат число " + b + " - Максимальное\n ");
    Console.Write("Результат число " + a + " - Минимальное\n ");
}