Console.Clear();



string f(int n, int m)
{
    if (n == m)
        return $"{m} ";
    return f(m, n - 1) + $"{n} ";
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n, m));
