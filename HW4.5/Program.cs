// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int n = 25;
            int[] arr = new int[n];
            int k = 0, sum ;
            Random rnd = new Random();
 
            for (int i = 0; i < n; i++)
            {
                arr[i] = rnd.Next(0, 99);
                Console.Write("{0} ", arr[i]);
            }

            var even = arr.Where((element, index) => index % 2 != 0);
            var odd = arr.Where((element, index) => index % 2 == 0);

            Console.WriteLine();
            Console.WriteLine("Чётные. Количество: {0}. Сумма: {1}.", even.Count(), even.Sum());
            Console.WriteLine();
            Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());
