// See https://aka.ms/new-console-template for more information
void FillOutputArray(int[] array)
{   Console.WriteLine("Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= new Random().Next(-9,10);
        if (i > 0)
            Console.Write(", ");
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
Console.Clear();
Console.WriteLine("Введите длину массива:");
int n = int.Parse(Console.ReadLine());
int[] a = new int[n];
FillOutputArray(a);
