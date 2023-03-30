Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= number; i++){
	
	Console.WriteLine(i * i);
}
