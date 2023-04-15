Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int inputNumber = Prompt("Введите число: ");

string result = string.Empty;
while (inputNumber > 0){
	result = Convert.ToString(inputNumber % 2) + result;
	inputNumber /= 2;
	
}
Console.WriteLine(result);