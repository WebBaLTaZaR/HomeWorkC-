void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void SwapFirstLastString(int[,] matrix)
{
    int minValue = matrix[0, 0], minRow = 0, minColumn = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minValue)
            {
                minValue = matrix[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }
    Console.WriteLine($"Минимум {minValue} на позиции({minRow + 1}, {minColumn + 1})");
    Console.WriteLine();
    Console.WriteLine("Конечный массив");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minRow)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minColumn)
                    Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальный массив");
InputMatrix(matrix);
SwapFirstLastString(matrix);