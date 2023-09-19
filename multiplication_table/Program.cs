// Создание таблицы умножения до введённого пользователем числа
//1 option

// Console.WriteLine("Input upper bound for multiplication table: ");
// int number = int.Parse(Console.ReadLine()!);
// for (int i = 1; i <= number; i++)
// {
//     for (int j = 1; j <= number; j++)
//     {
//         int result = i * j;
//         Console.Write(result);
//         Console.Write("\t");
//     }
//     Console.WriteLine();
// }


//2nd option
Console.WriteLine("Input upper bound for multiplication table: ");
int number = int.Parse(Console.ReadLine()!);
int[,] matrix = new int[number, number];

for (int i = 0; i < number; i++)
{
    for (int j = i; j < number; j++)
    {
        matrix[i, j] = (i + 1) * (j + 1);
        matrix[j, i] = (i + 1) * (j + 1);
    }
}

for (int i = 0; i < number; i++)
{
    for (int j = 0; j < number; j++)
    {
        Console.Write(matrix[i, j]);
        Console.Write("\t");
    }
    Console.WriteLine();
}
