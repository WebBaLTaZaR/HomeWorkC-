Console.Clear();

int num = Convert.ToInt32(Console.ReadLine());
int n = num;
int rev = 0;
while (num > 0)
{
    int dig = num % 10;
    rev = rev * 10 + dig;
    num = num / 10;
}
if (n == rev)
	Console.WriteLine($"{n} - палиндром");
else
	Console.WriteLine($"{n} - не палиндром");


