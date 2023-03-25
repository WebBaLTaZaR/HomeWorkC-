// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.Write("ВВедите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("ВВедите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (Convert.ToBoolean(firstNumber % 2)){
	Console.WriteLine($"{firstNumber} - нечётное число");
}else{
	Console.WriteLine($"{firstNumber} - чётное число");
}

if (Convert.ToBoolean(secondNumber % 2)){
	Console.WriteLine($"{secondNumber} - нечётное число");
}else{
	Console.WriteLine($"{secondNumber} - чётное число");
}