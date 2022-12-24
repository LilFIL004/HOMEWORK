// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] array = new int[2, 2, 2];
DoArray(array);
PechatIndexElements(array);
void PechatIndexElements(int[,,] ar)
{
    for (int x = 0; x < array.GetLength(0); x ++)
    {
        for (int y = 0; y < array.GetLength(1); y ++)
        {
            Console.WriteLine();
            for (int z = 0; z < array.GetLength(2); z ++)
            {
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            }
        }
    }
}
void DoArray(int[,,] ar)
{
    int count = 60;
    for (int x = 0; x < ar.GetLength(0); x ++)
    {
        for (int y = 0; y < ar.GetLength(1); y ++)
        {
            for (int z = 0; z < ar.GetLength(2); z ++)
            {
                ar[x, y, z] += count;
                count += 3;
            }
        }
    }
}

