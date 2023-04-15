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
	for(int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-10, 100);
}
int SearchCountOddIndexNumber(int[] array){
	int count = 0;
for(int i=1; i < array.Length; i = i+2){
	count = count + array[i];
} return count;
}
CreateRandomArray(array);
Console.WriteLine($" Массив [{String.Join(",", array)}]");
Console.WriteLine(SearchCountOddIndexNumber(array));