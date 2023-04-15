Console.Clear();

Console.WriteLine("Введите чило: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = 1;
for(int i = 2; i <= n; i++){
	result = result * i ;
	Console.WriteLine(result);
}
