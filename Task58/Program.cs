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

Console.Write("Введите размеры первого массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] firstMatrix = new int[size[0], size[1]];

Console.Write("Введите размеры второго массива: ");
int[] secondSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] secondMatrix = new int[secondSize[0], secondSize[1]];

while(size[0] != secondSize[0] || size[1] != secondSize[1]){
	Console.Write("для корректной работы, размеры должны быть одинаковыми: ");
	secondSize = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
	secondMatrix = new int[secondSize[0], secondSize[1]];
}

int[,] proizvMatrix(int[,] matrix, int[,] matrix2)
{
	int[,] mixMatrix = new int[firstMatrix.GetLength(0), firstMatrix.GetLength(1)];
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			mixMatrix[i, j] = matrix[i, j] * matrix2[i, j];
		}
	}
	return mixMatrix;
}






InputMatrix(firstMatrix);
Console.WriteLine("Первый двумерный массив");
Console.WriteLine();
PrintMatrix(firstMatrix);
InputMatrix(secondMatrix);
Console.WriteLine("Второй двумерный массив");
Console.WriteLine();
PrintMatrix(secondMatrix);
Console.WriteLine("Произведение двух двумерных массивов");
Console.WriteLine();
PrintMatrix( proizvMatrix(firstMatrix, secondMatrix));
