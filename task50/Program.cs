// task 50

string get_pos(int[,] matrix, int[] pos)
{
    if (matrix.GetLength(0) > pos[0] && matrix.GetLength(1) > pos[1])
        return "На этой позиции -> " + matrix[pos[0], pos[1]].ToString();
    return "->Такой позиции нет";
}

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

Console.Clear();
Console.WriteLine("Введите координаты в матрице:");
int[] pos = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
pos[0]--;
pos[1]--;
int[,] matr = new int[5, 5];
fill_matrix(matr);
Console.WriteLine(get_pos(matr, pos));