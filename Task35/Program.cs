
namespace HelloWorld
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}


void CreateRandomArray( int[] array){
	for(int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-100, 100);
}

int count = 0;
int SearchNumber(int[] array){
	for(int i = 0;i < array.Length; i++){
		if (array[i] > 9 && array[i] < 100){
			count++;
			
		}
	}
	return count;
}

int number = Prompt("Введите число: ");
int[] array = new int[number];
CreateRandomArray(array);
Console.WriteLine($" Массив [{String.Join(",", array)}]");
Console.WriteLine(SearchNumber(array));
		}
	}
}


