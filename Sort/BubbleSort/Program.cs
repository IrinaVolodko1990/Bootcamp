Console.Clear();
Console.WriteLine("Input size of array: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = new int[size];

int[] FillArrray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-12, 13);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.WriteLine($"Array: [{string.Join(" ", arr)}]");

}

int[] BubbleSort(int[] array)
{
    for (int i = 0; i < size - 1; i++)
    {
        for (int j = 0; j < size - 1 - i; j++)
        {
            if (array[j] > array[j + 1])
            {
                int temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
    return array;
}


PrintArray(FillArrray(array));
PrintArray(BubbleSort(array));

