int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-12, 20);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    // Console.WriteLine("Some array: ");
    // for (int i = 0; i < arr.Length; i++)
    // {
    //     Console.Write($"{arr[i]} ");
    // }
    // Console.WriteLine();
    Console.WriteLine ($"Some array: [{string.Join(" ", arr)}]");
}
int[] SortedArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        int minIndex = i;
        for (int j = i; j < arr.Length; j++)
        {
            if (arr[j] < arr[minIndex])
            {
                minIndex = j;
            }
        }
        if (arr[minIndex] == arr[i]) continue;
        int temp = arr[i];
        arr[i] = arr[minIndex];
        arr[minIndex] = temp;
    }
    return arr;

}
Console.Clear();
Console.WriteLine("Input array size: ");
int size = int.Parse(Console.ReadLine()!);
int[] mas = FillArray(size);
PrintArray(mas);
int[] newMass = SortedArray(mas);
PrintArray(newMass);