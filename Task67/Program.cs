Console.Clear();



int f(int n)
{
    if (n % 10 == 0 || n < 10 || n / 10 == n)
        return n;
    return f(n / 10) + n % 10  ;
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(n));
