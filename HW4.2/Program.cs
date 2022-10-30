//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
void FillArray(int[] massiv)
{
    Random Znach = new Random();
    for (int ind = 0; ind < massiv.Length; ind++)
    {
        massiv[ind] = Znach.Next(0, 9);
    }
}
void PrintArray(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Array = new int[12];
FillArray(Array);
PrintArray(Array);
Console.WriteLine(" ");
int summa_polojitelnih = 0;
int summa_otricatelnih = 0;
for (int ind = 0; ind < Array.Length; ind++)
{
    if (Array[ind] < 0)
    {
        summa_otricatelnih += Array[ind];
    }
    if (Array[ind] > 0)
    {
        summa_polojitelnih += Array[ind];
    }
};
Console.WriteLine($"Сумма положительных чисел {summa_polojitelnih}");
Console.WriteLine($"Сумма отрицательных чисел {-summa_otricatelnih}");

