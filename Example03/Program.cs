int [] initArray(int length)
{
    int [] array = new int [length];
    Random asd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = asd.Next(1, 100);
    }
    return array;
}

void PrintArray(int [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

void SumArray(int[] arr)
{
    int summ = 0;
    if (arr[0] > arr[4])
        summ = arr[0] - arr[4];
    else
        summ = arr[4] - arr[0];
    
    Console.WriteLine(summ);
}
int [] array = initArray(5);
PrintArray(array);
SumArray(array);

