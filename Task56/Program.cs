Console.Clear();


void InputMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
			matrix[i, j] = new Random().Next(10, 20);
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

int MinSortMatrix(int[,] matrix)
{
	int count = 0;
	int minRow = 0;
	for (int k = 0; k < matrix.GetLength(1); k++)
	{
		minRow += matrix[0, k]; // цикл для нахождения первой суммы чисел, для сравнения с остальными в последующих циклах.
	}

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			count += matrix[i, j];

		}
		if (count < minRow)
		{
			minRow = count;
		}

	}
	return minRow;

}

Console.Write("Введите прямоугольные размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
while (size[0] == size[1])
{
	Console.WriteLine("Числа не могут быть одинаковыми");
	size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
	matrix = new int[size[0], size[1]];
}
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
Console.WriteLine();
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine($"минимальная строка имеет сумму {MinSortMatrix(matrix)}");
Console.WriteLine("Как узнать строку, не допёр");


