// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] table = new int[3, 4];
DoArrayRandom(table);
PechatArray(table);
ElementsPoUbivaniuArray(table);
Console.WriteLine();
PechatArray(table);
void DoArrayRandom(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x ++)
    {
        for (int y = 0; y < array.GetLength(1); y ++)
        {
            array[x, y] = new Random().Next(1, 10);
        }
    }
}
void ElementsPoUbivaniuArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x ++)
    {
        for (int y = 0; y < array.GetLength(1); y ++)
        {
            for (int z = 0; z < array.GetLength(1) - 1; z ++)
            {
                if (array[x, z] < array[x, z + 1])
                {
                    int temp = array[x, z + 1];
                    array[x, z + 1] = array[x, z];
                    array[x, z] = temp;
                }
            }
        }
    }
}
void PechatArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x ++)
    {
        for (int y = 0; y < array.GetLength(1); y ++)
        {
            Console.Write($"{array[x, y]} ");
        }
        Console.WriteLine();
    }
}