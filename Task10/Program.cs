Console.Clear();

int hundreds = new Random().Next(100,1000);
Console.WriteLine(hundreds);
int dozens = (hundreds % 100);
int units = (hundreds % 10);
Console.WriteLine(dozens/10);
