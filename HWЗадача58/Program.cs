// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int a = 2;
int b = 2;
int[,] arrayOne = {{2,4} , {3, 2}};
int[,] arrayTwo = {{3,4} , {3, 3}};
int [,] rezultArrays = new int[a, b];
PechatArray(arrayOne);
PechatArray(arrayTwo);
PechatArray(RezultMatrix(arrayOne, arrayTwo,rezultArrays));
int[,] RezultMatrix(int[,] matrixOne,int[,] matrixTwo,int[,] rezultMatrix)
{
    for (int x = 0; x < matrixOne.GetLength(0); x ++)
    {
        for (int y = 0; y < matrixOne.GetLength(1); y ++)
        {
            rezultMatrix[x ,y] = 0;
            for (int z = 0; z < matrixOne.GetLength(1); z ++)
            rezultMatrix[x, y] += matrixOne[x, z]*matrixTwo[z, y];
        }

    }
    return rezultMatrix;
}
void PechatArray(int[,] ar)
{
    for (int x = 0; x < ar.GetLength(0); x ++)
    {
        for (int y = 0; y < ar.GetLength(1); y ++)
        {
            Console.Write($"{ar[x, y]} ");

        }
        Console.WriteLine("");
    }
    Console.WriteLine("");
}