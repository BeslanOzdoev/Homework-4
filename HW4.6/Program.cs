// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.


void Array_Input(int[] arr, int min, int max)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max);
            }
}
void Array_Output(int[] arr)
{
    foreach (var element in arr)
    {
        Console.Write($"{element} ");
    }
}
Console.Write("Min: ");
int Min = int.Parse(Console.ReadLine() ?? "0" );
Console.Write("Max: ");
int Max = int.Parse(Console.ReadLine() ?? "0" );
Console.Write("Length of Array: ");
int n = int.Parse(Console.ReadLine() ?? "0" );
int[] Array =  new int[n];
Array_Input(max: Max + 1, min: Min, arr: Array);
Array_Output(Array);
Console.WriteLine("");
for (int i = 0; i <= Array.Length/2; i++)
{
    if (((Array.Length % 2) == 1) && (i == Array.Length / 2)) Console.WriteLine($"Произведение пары чисел: {Array[i] * Array[i]}");
    if (((Array.Length % 2) == 0) && (i == Array.Length / 2)) Console.WriteLine($"-");
    else Console.WriteLine($"Произведение пары чисел: {Array[i] * Array[Array.Length -1 -i]}");
}
