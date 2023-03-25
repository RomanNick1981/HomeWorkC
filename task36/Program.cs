void FillOutputArray(int[] array) // создание массива
{ 
Console.WriteLine("Сгенерированный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next (1,100); // Генерация массива
        if (i > 0) 
        Console.Write(", ");
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
// БАЗА
Console.Clear();
Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
// БАЗА
int[] arr = new int[n];
FillOutputArray(arr);
//ЭТО БАЗА

int summ = 0;
for (int i = 1; i < arr.Length; i+=2)
    summ=+summ + arr[i];
Console.WriteLine(summ);