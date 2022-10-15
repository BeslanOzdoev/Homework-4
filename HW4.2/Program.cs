// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

            int[] arr = new int[12];
            int k = 0, sum1 = 0;
            int l = 0, sum2 = 0;
            Random rnd = new Random();
 
            for (int i = 0; i < 12; i++)
            {
                arr[i] = rnd.Next(-0, 9);
                Console.Write("{0} ", arr[i]);
            }

            foreach(int element in arr)
            {
                if (element > 0)
                {
                    k++;
                    sum1 += element;
                }   
     
            if (element < 0)
            {
                l++;
                sum2 += element;
            }
            }
            Console.WriteLine("Количество положительных элементов {0}, сумма положительных элементов {1}", k, sum1);
            Console.WriteLine("Количество отрицательных элементов {0}, сумма отрицательных элементов {1}", l, sum2);
