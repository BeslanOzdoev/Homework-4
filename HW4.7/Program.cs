// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

            int n = 12;
            int[] arr = new int[n];
            int max = int.MinValue;
            int min = int.MaxValue;
            
            Random rnd = new Random();
 
            for (int i = 0; i < n; i++)
            {
            {
                arr[i] = rnd.Next();
                Console.Write("{0} ", arr[i]);
            }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            int delta = max - min;

Console.WriteLine();
Console.WriteLine("Максимальное значение: {0}, минимальное значение: {1}, разница между максимальным и минимальным значением: {2}", max, min, delta);
