Console.Clear();

int Prompt(string message){
	Console.Write(message);
	string? value = Console.ReadLine();
	int result = Convert.ToInt32(value);
	return result;
}

int a = Prompt("Введите первую сторону треугольника: ");
int b = Prompt("Введите вторую сторону треугольника: ");
int c = Prompt("Введите третью сторону треугольника: ");

if(a <= (b + c) && b <= (a + c) && c <= (b + a) ){
	Console.WriteLine("yes");
}
else Console.WriteLine("no");