Console.Clear();

Console.Write("Введите цифру от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());

while(number > 7 || number < 1){
	Console.Write("Введите цифру от 1 до 7: ");
	number = Convert.ToInt32(Console.ReadLine());
}
if(number == 6 || number == 7)
	Console.WriteLine("Да детка, это выходные!");
else 
	Console.WriteLine("Это будний день, иди работать!");