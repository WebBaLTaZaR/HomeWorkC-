Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int n =Prompt("Введите кол-во элементов массива: ");
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 11); // [1, 10]
Console.WriteLine($"[{string.Join(", ", array)}]");
