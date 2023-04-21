Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

string f(int n)
{
    if (n == m)
        return $"{m} ";
    return f(n - 1) + $"{n} ";
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine(f(n));
