// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите количество кубов:");
int n = Convert.ToInt32(Console.ReadLine());
while(n < 1){
    Console.WriteLine("Введите натуральное число!");
    int n = Convert.ToInt32(Console.ReadLine());
}
Console.Write(1);
for(int i = 2; i <= n; i += 1)
{
    Console.Write(", " + Math.Pow(i, 3));
}
Console.WriteLine(".");