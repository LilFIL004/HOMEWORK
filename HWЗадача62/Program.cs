// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int vol = 4;
int[,] table = new int[vol, vol];
DoArraySpiral(table, vol);
PechatArray(table);
void DoArraySpiral(int[,] array, int b)
{
    int x = 0, y = 0;
    int num = 1;
    for (int a = 0; a < b * b; a ++)
    {
        int z = 0;
        do { array[x, y ++] = num ++; } while (++ z < b - 1);
        for (z = 0; z < b - 1; z ++) array[x ++, y] = num ++;
        for (z = 0; z < b - 1; z ++) array[x, y --] = num ++;
        for (z = 0; z < b - 1; z ++) array[x --, y] = num ++;
        ++ x; ++ y;
        b = b < 2 ? 0 : b - 2;
    }
}
void PechatArray(int[,] array)
{
    for (int x = 0; x < array.GetLength(0); x ++)
    {
        for (int y = 0; y < array.GetLength(1); y ++)
        {
            if (array[x, y] < 10)
            {
                Console.Write("0" + array[x, y]);
                Console.Write(" ");
            }
            else Console.Write(array[x, y] + " ");
        }
        Console.WriteLine();
    }
}

