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




Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
Console.WriteLine("Введите координаты искомого элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
Console.WriteLine();
PrintMatrix(matrix);
CheckMatrix(matrix);


void CheckMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++){
			if(i == x && j == y)
				Console.WriteLine(matrix[i,j]);
			else Console.WriteLine("Такой позиции нет"); 
			}
    }
}