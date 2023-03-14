// Задача 15
Console.WriteLine("Введите день недели (введите число от 1 до 7)");
int a = Convert.ToInt32(Console.ReadLine());
string str;

while (a < 1 || a > 7)
{
    a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введен неправильно день недели (введите число от 1 до 7)");
}
if (a > 5)
    str = "Выходной день";
else
    str = "Будний день";
Console.WriteLine(str);