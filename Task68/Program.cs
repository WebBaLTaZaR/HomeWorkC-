Console.Clear();

int f(int n, int m)
{
	if (n == 0) return m + 1;
	if (n != 0 && m == 0) return f(n - 1, 1);
	if (n > 0 && m > 0) return f(n - 1, f(n, m - 1));
	return f(n, m);
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));
