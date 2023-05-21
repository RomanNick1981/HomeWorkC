// final task
// Функция ввода пункта меню
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
// Функция вывода массива
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
// Ввод пункта меню
int res;
try 
{
    res = menu(0);
}
catch (FormatException e)
{
    res = -1;
}
while ((res < 0) || (res > 2))
{
    try {
        res = menu(1);
    }
    catch (FormatException e)
    {
        res = -1;
    }
}

string[] array = new string[] {};
int n = 0;
// Обработка пункта меню
switch (res)
{
    // Первый пункт - автозаполнение
    case 1:
        array = new string[] { "Hello", "2", "world", ":-)" };
        n = 4;
        break;
    // Второй пункт - ввод с клавиатуры
    case 2:
        while (n <= 0)
        {
            Console.WriteLine("Введите размер массива");
            try {
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException e)
            {
            Console.WriteLine("Неверный размер массива!");
                n = -1;
            }
        }
        array = new string[n];
        Console.WriteLine("Введите элементы массива слов, через новую строку");
        for(int i = 0; i < n; i++)
            array[i] = Console.ReadLine();
        break;
    // В остальных случаях выход из окружения
    default:
        Environment.Exit(0);
        break;
}

// Создание размера нового массива
int m = 0;
for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
        m++;
}

// Создание самого массива
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