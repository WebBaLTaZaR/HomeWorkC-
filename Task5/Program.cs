Console.Clear();

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
for(int i = -number;i <= number; i++ ){
		Console.WriteLine(i);
}