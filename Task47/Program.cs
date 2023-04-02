// Task 47
void fill_matrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
}

void print_matrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write(matrix[i, j].ToString() + " ");
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Введите размеры матрицы:");
int[] mn = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
double[,] matr = new double[mn[0], mn[1]];
fill_matrix(matr);
print_matrix(matr);