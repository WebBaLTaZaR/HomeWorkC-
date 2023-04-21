Console.Clear();

int f(int n, int m)
{
    if (n == m || n == 0)
        return m;
    return f(m, n - 1) + m;
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));
