Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}


void CreateRandomArray( int[] array){
	for(int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-10, 11);
}

int n = Prompt("Введите длину массива: ");
int[] array = new int[n];
CreateRandomArray(array);
Console.WriteLine($" Массив [{String.Join(",", array)}]");
int search = Prompt("Введите число, которое хотите найти: ");



string CheckNumber(int[] array){
for (int i = 0; i < array.Length;i++)
	if(array[i] == search){
		return "yes";
	}
	return "no";
}

Console.WriteLine(CheckNumber(array));	