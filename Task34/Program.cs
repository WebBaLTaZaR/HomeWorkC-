Console.Clear();

int[] array = new int[10];

void CreateRandomArray( int[] array){
	for(int i = 0; i < array.Length; i++)
		array[i] = new Random().Next(100, 1000);
}

int SearchCountEvenNumber(int[] array){
	int count = 0;
	for(int i = 0; i < array.Length; i++){
		if (array[i] % 2 == 0){
			count++;
		}
		
	}
	return count;
}

CreateRandomArray(array);
Console.WriteLine($" Массив [{String.Join(",", array)}]");
Console.WriteLine(SearchCountEvenNumber(array));