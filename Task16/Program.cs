Console.Clear();

Console.Write("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst * numberFirst == numberSecond || numberSecond * numberSecond == numberFirst)
	Console.WriteLine("да");
else
	Console.WriteLine("нет");