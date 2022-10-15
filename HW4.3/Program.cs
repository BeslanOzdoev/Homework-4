// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

            int n = 12;
            int[] arr = new int[n];
            int k = 0, l = 0;
            Random rnd = new Random();
 
            for (int i = 0; i < 12; i++)
            {
                arr[i] = rnd.Next(100, 999);
                Console.Write("{0} ", arr[i]);
            }

            foreach(int element in arr)
            {
                if (element % 2 == 0)
                {
                    k++;
                    l = n - k;
                }   

            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов = {0}, Количество нечетных элементов = {1}", k, l);

