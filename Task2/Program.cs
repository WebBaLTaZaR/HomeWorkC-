// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber > secondNumber){
	Console.WriteLine($"{firstNumber} явно больше, чем {secondNumber}");
}else if(secondNumber > firstNumber) {
	Console.WriteLine($"{secondNumber} явно больше, чем {firstNumber}");
}else{
	Console.WriteLine("Эти числа равны, не видишь, что-ли?))");
}
Console.WriteLine("Если хочешь повторить, введи в консоли 'dotnet run' ");
