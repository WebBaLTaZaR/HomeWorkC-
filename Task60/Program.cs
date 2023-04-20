Console.Clear();


void InputMatrix(int[,,] matrix)
{
	int count = 1;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				matrix[i, j, k] = count++;
			}
		}
	}
}

void PrintMatrix(int[,,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			for (int k = 0; k < matrix.GetLength(2); k++)
			{
				Console.WriteLine($"{matrix[i, j, k]} ({i}, {j}, {k})");
				Console.WriteLine();
			}
		}


	}
}

Console.Write("Введите размеры первого массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix = new int[size[0], size[1], size[2]];

InputMatrix(matrix);
PrintMatrix(matrix);
