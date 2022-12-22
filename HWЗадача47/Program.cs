// Задайте двумерный массив размером m × n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m = 3;
int n = 4;
double[,] array = new double[m, n];
PechatArray(DoArray(array));

double[,] DoArray(double[,] arr)
{
    for (int a = 0; a < arr.GetLength(0); a ++)
    {
        for (int b = 0; b < arr.GetLength(1); b ++)
        {
            arr[a, b] = new Random().NextDouble()+ new Random().Next(-10, 10);
           }
    }
    return arr;
}

void PechatArray(double[,] ar)
 {
    for (int a = 0; a < ar.GetLength(0); a ++)
    {
        for (int b = 0; b < ar.GetLength(1); b ++)
        {
            Console.Write($"{ Math.Round(ar[a, b],1)} ");
        }
        Console.WriteLine("");
    }
}
