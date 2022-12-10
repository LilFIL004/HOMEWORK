// Напишите программу, котрая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

pechatMassiv(Numbers(numArray(8)));
int[] numArray(int arrayLenght)
{
    int[] chislo = new int [arrayLenght];
    return chislo;
}
int[] Numbers(int[]num)
{
    for (int a = 0; a < num.Length; a ++)
    {
        num[a] = new Random().Next(0, 50);
    }
     return num;
}
void pechatMassiv(int[] array)
{
    foreach(int a in array)
    {
      Console.WriteLine($"{a}");
    }
}