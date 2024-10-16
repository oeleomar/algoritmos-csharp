class InsertionSort
{
    public static void Main()
    {
        int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
        Sort(arr);
        PrintArray(arr);
    }

    static void Sort(int[] arr)
    {
        int count = 0;
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
                count++;
            }
            arr[j + 1] = key;
        }
        Console.WriteLine("Nº de vezes executado: " + count);
    }

    static void PrintArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n; ++i)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}
