Console.Clear();



double[] array = new double[9];

void CreateRandomArray( double[] array){
	for(int i = 0; i < array.Length; i++)
		array[i] = Math.Round(new Random().NextDouble() * (30 - 10) + 10, 2);
}
CreateRandomArray(array);
Console.WriteLine($" Массив [{String.Join(", ", array)}]");


double SearchDifferenceMaxAndMin(double[] array){
	double max = array[0];
	double min = array[0];
	double result = 0;
	for(int i = 1; i < array.Length; i++){
		if (array[i] > max){
			max = array[i];
		}
		else if(array[i] < min){
			min = array[i];
		}
		result = max - min;
	}
	return result;
}
Console.WriteLine(SearchDifferenceMaxAndMin(array));