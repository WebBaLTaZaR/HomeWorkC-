Console.Clear();
int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int numberFirst = Prompt("Введите первое число : ");
int numberSecond = Prompt("Введите второе число : ");
int result = 1;
for (int i = 1; i <= numberSecond ; i++) {
	result *= numberFirst;
}
Console.WriteLine(result);