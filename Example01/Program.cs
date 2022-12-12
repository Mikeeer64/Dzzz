int [] initArray(int length)
{
    int [] array = new int [length];
    Random asd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = asd.Next(100, 999);
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

void ChetArray(int[] array)
{
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            index += 1;
    }
    Console.WriteLine(index);
}

int [] array = initArray(10);
PrintArray(array);
ChetArray(array);





