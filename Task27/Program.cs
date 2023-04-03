Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int number = Prompt("Введите число: ");

int result = 0;
while(number > 0){
	result = result + number%10;
	number = number/10;
}
Console.WriteLine(result);
    