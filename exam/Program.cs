// final task
int menu(int error)
{
    Console.Clear();
    Console.WriteLine("Выберите вариант массива");
    Console.WriteLine("1. Использовать готовый массив - [“Hello”, “2”, “world”, “:-)”]");
    Console.WriteLine("2. Ввести массив вручную");
    Console.WriteLine("0. Выход");
    if (error > 0)
        Console.WriteLine("Такой команды нет!");
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

void print_array(int size, string[] arr)
{
    Console.WriteLine("Полученный массив:");
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        if (i > 0)
            Console.Write(", “" + arr[i] + "”");
        else
            Console.Write("“" + arr[i] + "”");
    }
    Console.WriteLine("]");
}

int res = menu(0);
while ((res < 0) || (res > 2))
{
    res = menu(1);
}
string[] array = new string[] {};
int n = 0;
switch (res)
{
    case 1:
        array = new string[] { "Hello", "2", "world", ":-)" };
        n = 4;
        break;
    case 2:
        Console.WriteLine("Введите размер массива");
        n = Convert.ToInt32(Console.ReadLine());
        array = new string[n];
        Console.WriteLine("Введите элементы массива слов, через новую строку");
        for(int i = 0; i < n; i++)
            array[i] = Console.ReadLine();
        break;
    default:
        Environment.Exit(0);
        break;
}

int m = 0;
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
        m++;
}
string[] result = new string[m];
m = 0;
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {
        result[m] = array[i];
        m++;
    }
}
print_array(m, result);