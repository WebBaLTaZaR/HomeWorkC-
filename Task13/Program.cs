Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number);
int hundreds = (number % 1000);
int dozens = (number % 100);
int units = (number % 10);
if (number < 100){
Console.WriteLine("Третьего числа нет");
}
else if (number > 999 && number < 10000 ){
	Console.WriteLine(hundreds);
}
// решения ещё не придумал