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
    for (int i = 0; i < arr.Length; i++)
    {
        if(i % 2 != 0)
        summ = summ + arr[i];
    }
    Console.WriteLine(summ);
}

int [] array = initArray(10);
PrintArray(array);
SumArray(array);
