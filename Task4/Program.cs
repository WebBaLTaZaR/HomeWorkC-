// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.Write("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Сейчас найдём из них максимальное");
if (firstNumber > secondNumber){
	if(firstNumber > thirdNumber){
		Console.WriteLine($"{firstNumber} явно больше, чем остальные");
}}else if(secondNumber > firstNumber) {
	if(secondNumber > thirdNumber) {
	Console.WriteLine($"{secondNumber} явно больше, чем остальные");
}}else if(thirdNumber > firstNumber) {
	if(thirdNumber > secondNumber){
	Console.WriteLine($"{thirdNumber} явно больше, чем остальные");
}}else{
	Console.WriteLine("Однозначно самого большого здесь нет");
}
Console.WriteLine("Если хочешь повторить, введи в консоли 'dotnet run' ");
