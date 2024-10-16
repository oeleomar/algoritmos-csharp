 class BubbleSort
    {
        public static void Main()
        {
            int[] numeros = { 5, 3, 2, 4, 7, 1, 0, 6 };
            Console.WriteLine("Array original:");
            PrintArray(numeros);

            BubbleSortMethod(numeros);

            Console.WriteLine("Array ordenado:");
            PrintArray(numeros);

        }

        static void BubbleSortMethod(int[] array)
        {
            int count = 0;
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
                count++;
                }
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
