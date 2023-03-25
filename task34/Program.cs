// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void FillOutputArray(int[] array) // создание массива
{   Console.WriteLine("Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(100,1000); // Пределы итой массива
        if (i > 0)
            Console.Write(", ");
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите количество цифр в массиве:");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
int count=0;
FillOutputArray(a); // Вывод массива
for (int i = 0; i < a.Length; i++)
    if(a[i] % 2 == 0)
        count++;
Console.WriteLine(count);
