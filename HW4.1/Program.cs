//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
void Zapolnenie_Massiva(int[] massiv)
{
    Random Znach = new Random();
        for(int ind = 0;ind<massiv.Length;ind++)
    {
        massiv[ind] = Znach.Next(0,2);
    }
}
void Pechat_Massiva(int[] massiv)
{
    foreach (var item in massiv)
    {
        Console.Write($"{item} ");
    }
}
int[] Array = new int[8];
Zapolnenie_Massiva(Array);
Pechat_Massiva(Array);
