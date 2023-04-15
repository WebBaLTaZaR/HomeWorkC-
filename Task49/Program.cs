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
void CheckMatrix(int[,] matrix)
{
    for (int i = 1; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 1; j < matrix.GetLength(1); j+=2){
				matrix[i,j] *= matrix[i,j];
			}
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
Console.WriteLine();
PrintMatrix(matrix);
CheckMatrix(matrix);
Console.WriteLine("Финальный массив");
Console.WriteLine();
PrintMatrix(matrix);