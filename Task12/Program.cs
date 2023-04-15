Console.Clear();
Console.Write("Введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst % numberSecond == 0 )
	Console.WriteLine("кратно");
else 
	Console.WriteLine($"не кратно, остаток {numberFirst % numberSecond}");