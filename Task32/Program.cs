Console.Clear();



void CreateRandomArray( int[] array){
	for(int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(-10, 11);
}


void ReversNumbersArray(int[] array){
for (int i = 0; i < array.Length;i++)
	array[i] = array[i] * (-1);
	
}


Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 
CreateRandomArray(array);
Console.WriteLine($"Начальный массив [{String.Join(",", array)}]");
ReversNumbersArray(array);
Console.WriteLine($"Не начальный массив [{String.Join(",", array)}]");	