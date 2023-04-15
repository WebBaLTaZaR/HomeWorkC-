Console.Clear();

int Prompt(string message)
{
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int n = Prompt("Введите число: ");

int result = 0;
int b = 1;
int tmp;
for (int i = 0; i < n; i++)
{
	tmp = result;
	result = b;
	b += tmp;
	Console.WriteLine(result);
}