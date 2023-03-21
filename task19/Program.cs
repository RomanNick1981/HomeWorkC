// Задача 19
Console.Clear();
Console.WriteLine("Введите Пятизначное число");
int n = Convert.ToInt32(Console.ReadLine());
while (n > 99999 || n < 10000)
{
    Console.WriteLine("Число не пятизначное!");
    n = Convert.ToInt32(Console.ReadLine());
}
string str = n.ToString();
int i = 0, j = str.Length - 1;
bool is_palindrome = true;
while (i < j)
{
    if (str[i] != str[j])
    {
        is_palindrome = false;
        break;
    }
    i += 1;
    j -= 1;
}
if (is_palindrome)
    Console.WriteLine("Число является палиндромом");
else
    Console.WriteLine("Число не является палиндромом");

// Console.Clear();
// Console.Write("Введите число: ");
// string n = Console.ReadLine()!;
// while (n.Length != 5)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = Console.ReadLine()!;
// }
// if (n[0] == n[4] && n[1] == n[3])
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine()!);
// while (n < 10000 || n > 99999)
// {
//     Console.Write("Вы ошиблись!\nВведите число: ");
//     n = int.Parse(Console.ReadLine()!);
// }
// int n1 = n / 10000;
// int n2 = (n / 1000) % 10;
// int n4 = (n % 100) / 10;
// int n5 = n % 10;
// if (n1 == n5 && n2 == n4)
//     Console.WriteLine("yes");
// else
//     Console.WriteLine("no");