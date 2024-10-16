class SelectionSort
{
    public static void Main()
    {
        int[] numeros = { 5, 3, 2, 4, 7, 1, 0, 6 };
        
        Console.WriteLine("Array original:");
        PrintArray(numeros);

        SelectionSortMethod(numeros);

        Console.WriteLine("Array ordenado:");
        PrintArray(numeros);

    }

    static void SelectionSortMethod(int[] array)
    {

        int count = 0;

        for (int i = 0; i < array.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
                count++;
            }
            int temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        Console.WriteLine("Nº de vezes executado: " + count);
    }

    static void PrintArray(int[] array)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
