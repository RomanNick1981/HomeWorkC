// Task13
Console.WriteLine("Введите число: ");

string str;
int a = Convert.ToInt32(Console.ReadLine());

while (a > 999)
    a /= 10;

if (a < 100)
    str = "Нет третьей цифры";
else 
    str = $"Третья цифра: {a%10}";

Console.WriteLine(str);
