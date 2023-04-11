Console.Clear();

int Prompt(string message)
{
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int number = Prompt("Введите число: ");
int[] array = new int[number];

int count = 0;
for (int i = 0; i < number; i++)
{
	array[i] = new Random().Next(-10, 11);
	if (array[i] > 0)
	{
		count++;

	}
}
Console.WriteLine($" Массив [{String.Join(",", array)}]");
Console.WriteLine(count);