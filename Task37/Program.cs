Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}
int number = Prompt("Введите число: ");
int[] array = new int[number];

void CreateRandomArray( int[] array){
	for(int i = 0; i < number; i++)
		array[i] = new Random().Next(-10, 11);
}

void SumEndArray(int[] array){
	for (int i = 0; i < array.Length / 2 + array.Length % 2;i++){
		Console.WriteLine($"{array[i] * array[array.Length - 1 - i]}");
	}
}
CreateRandomArray(array);

Console.WriteLine($" Массив [{String.Join(",", array)}]");
SumEndArray(array);