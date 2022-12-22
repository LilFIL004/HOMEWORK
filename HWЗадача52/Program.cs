//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int a = 3;
int b = 4;
int[,] array = new int[a, b];
DoArray(array);
PechatArray(array);
PechatMiddleNumArray(MiddleNum(array));
void DoArray(int[,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x ++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            array[x, y] = new Random().Next(0, 10);
        }
    }
}
void PechatArray(int[,] ar)
{
    for (int x = 0; x < ar.GetLength(0); x ++)
    {
        for (int y = 0; y < ar.GetLength(1); y ++)
        {
            Console.Write($"{ar[x, y],1} ");
        }
        Console.WriteLine("");
    }
}
double[] MiddleNum(int[,] ar)
{
    double[] mdl = new double[ar.GetLength(1)];
    for (int x = 0; x < ar.GetLength(0); x ++)
    {
        for (int y = 0; y < ar.GetLength(1); y ++)
        {
            mdl[y] += Convert.ToDouble(ar[x, y]);
        }
    }
    for (int z = 0; z < mdl.Length; z ++)
    {
        mdl[z] /= ar.GetLength(0);
       
    }
    return mdl;
}
void PechatMiddleNumArray(double[] mdlArray)
{
    for (int x = 0; x < mdlArray.Length; x ++)
    {
        Console.WriteLine($"Среднеарифмитическое столбца № {x + 1} = {mdlArray[x]}");
    }
}
