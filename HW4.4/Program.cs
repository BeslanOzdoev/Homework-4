// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int n = 123;
            int[] arr = new int[n];
            int k = 0;
            Random rnd = new Random();
 
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 999);
                Console.Write("{0} ", arr[i]);
            }

            foreach(int element in arr)
            {
                if (element >= 10 && element <= 99)
                {
                    k++;
                }   

            }
            Console.WriteLine();
            Console.WriteLine("Количество элементов из отрезка [10,99] = {0}", k);