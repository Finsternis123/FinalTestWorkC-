string[] Array = new string[4] {"hello", "2", "world", ":-)"};
string[] Array1 = new string[Array.Length];

void SortArray (string[] Array, string[] Array1)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            Array1[count] = Array[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SortArray(Array, Array1);
PrintArray(Array1);