namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			

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
            Console.Write("Введите размеры массива: ");
            int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
            int[,] matrix = new int[size[0], size[1]];
            InputMatrix(matrix);
            Console.WriteLine("Начальный массив");
            Console.WriteLine();
            PrintMatrix(matrix);
            CheckMatrix(matrix);

            void CheckMatrix(int[,] matrix)
            {
                
                double count = Convert.ToDouble(0);
                double result = Convert.ToDouble(0);
                double empty = Convert.ToDouble(0);
                for (int i = 0; i < matrix.GetLength(0); i++)
                { 
                    for (int j = 0; j < matrix.GetLength(1); j++){
                        count += matrix[j, i]; 
                        result = count;
                }
                Console.WriteLine(Math.Round(result /= matrix.GetLength(1),2));
                count = empty;
            }}
        }}}

