Console.Clear();

Console.Write("Введите четверть от одного до четырёх: ");
int quarter = Convert.ToInt32(Console.ReadLine());
while(quarter < 1 || quarter > 4){
	Console.Write("ПОВТОРЯЮ, Введите четверть от одного до четырёх: ");
	quarter = Convert.ToInt32(Console.ReadLine());
}

if (quarter == 1)
	Console.WriteLine("x > 0 && y > 0");
else if (quarter == 2)
	Console.WriteLine("x < 0 && y > 0");
else if (quarter == 3)
	Console.WriteLine("x < 0 && y < 0");
else
	Console.WriteLine("x > 0 && y < 0");