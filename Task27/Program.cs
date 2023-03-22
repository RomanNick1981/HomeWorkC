// Task27
Console.Clear();
Console.WriteLine("Введите число: ");
String a = Console.ReadLine();
int Sum = 0;
for ( int i = 0; i < a.Length ;i++)
{
    Sum += a[i] - '0';
}
Console.WriteLine(Sum);