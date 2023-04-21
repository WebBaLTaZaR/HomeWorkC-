int f(int a, int b)
{
    if (b == 0)
        return 1;
    return f(a,b - 1) * a;
}


Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(a,b));
