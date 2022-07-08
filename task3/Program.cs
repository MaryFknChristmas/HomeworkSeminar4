Task3();

void Task3()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    
    Console.WriteLine();
    
    for (int i = array.Length - 1; i > 0; i--)
    {
        for(int j = 0; j < i; j++)
        {
            if (Math.Abs(array[j]) > Math.Abs(array[j+1]))
            {
                int temp = array[j];
                array[j] = array[j+1];
                array[j+1] = temp;
            }
        }
    }

    PrintArray(array);

}

void FillArray(int[] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-10, 11);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
