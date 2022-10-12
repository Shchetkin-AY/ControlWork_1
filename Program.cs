string[] arr = new string[6]{"1234", "1567", "-2", "computer science", "1", "ABS"};
string[] result = new string[arr.Length];

void Searcher(string[] arr, string[] result)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count ++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
Searcher(arr, result);
PrintArray(result);
