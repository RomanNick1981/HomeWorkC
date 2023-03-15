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
