// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Введите количество кубов:");
int m = Convert.ToInt32(Console.ReadLine());
while(m < 1){
    Console.WriteLine("Введите натуральное число!");
    m = Convert.ToInt32(Console.ReadLine());
}
Console.Write(1);
for(int i = 2; i <= m; i += 1)
{
    Console.Write(", " + Math.Pow(i, 3));
}
Console.WriteLine(".");