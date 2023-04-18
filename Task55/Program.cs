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
void RelacementMatrix(int[,] matrix){
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = i+1; j < matrix.GetLength(1); j++){
			int count = matrix[i,j];
			matrix[i,j] = matrix[j,i];
			matrix[j,i] = count;
		}
	}
}

Console.Write("Введите 2 одинаковых числа: ");

int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
while (size[0] != size[1])
{
	Console.Write("Введите 2 одинаковых числа: ");
	size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
	matrix = new int[size[0], size[1]];
}
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
Console.WriteLine();
PrintMatrix(matrix);
RelacementMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);