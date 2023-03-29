// Списал) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void AddArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {   
        System.Console.WriteLine("Введите число: ");
        array[i]=int.Parse(Console.ReadLine()!);
    }
}

Console.Clear();
System.Console.WriteLine("Сколько чисел планируете ввести?");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int [n];
AddArray(array);
int countplus=0;
int countminus=0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
        {
            countplus+=1;
        }
        // else
        //     countminus+=1;
    }
System.Console.WriteLine($"Чисел больше 0: {countplus}");
// System.Console.WriteLine($"Отрицательных чисел: {countminus}");