namespace BubbleSort
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] numeros = { 5, 3, 2, 4, 7, 1, 0, 6 };
            Console.WriteLine("Array original:");
            PrintArray(numeros);

            BubbleSort(numeros);

            Console.WriteLine("Array ordenado:");
            PrintArray(numeros);

        }

        static void BubbleSort (int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
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
}

