// task 52
void print_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j].ToString() + " ");
        Console.WriteLine();
    }
}

void fill_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(-9, 10);
    print_matrix(matrix);
}

void print_avgs(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
            sum += (double)matrix[j, i];
        sum /= matrix.GetLength(0);
        if (i > 0)
            Console.Write(", ");
        Console.Write(Math.Round(sum, 2));
    }
    Console.WriteLine();
}

Console.Clear();
Console.WriteLine("Введите размеры матрицы:");
int[] mn = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matr = new int[mn[0], mn[1]];
fill_matrix(matr);
print_avgs(matr);