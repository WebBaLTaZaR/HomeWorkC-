Console.Clear();


void InputMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(10, 99);
	}
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			Console.Write($"{matrix[i, j]} \t");
		Console.WriteLine();
	}
}
void RelacementMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(1); i++)
	{
		int count = matrix[0, i];
		matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
		matrix[matrix.GetLength(0) -1,i] = count;
	}
}

Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
Console.WriteLine();
PrintMatrix(matrix);
RelacementMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);