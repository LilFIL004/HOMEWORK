// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int a = 3;
int b = 4;
int[,] array = new int[a, b];
Console.WriteLine("Введите значение элемента массива");
int nameNumber = Convert.ToInt32(Console.ReadLine());
DoArray(array);
PechatArray(array);
NaidemEltmentArray(array, nameNumber);
void DoArray(int[,] arr)
{
    for (int x = 0; x < arr.GetLength(0); x ++)
    {
        for (int y = 0; y < arr.GetLength(1); y ++)
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
void NaidemEltmentArray(int[,] ar, int num)
{ int find=0;
    for (int x = 0; x < ar.GetLength(0); x ++)
    {
        for (int y = 0; y < ar.GetLength(1); y ++)
        {
            if (num == array[x,y]) 
     {
        Console.WriteLine($"Значение {num} находится в массиве по координатам {x} {y} ");   
            find ++;  
    }
        } 
    } 
  if (find == 0) Console.WriteLine($"Значения {num} в массиве нет ");
} 
