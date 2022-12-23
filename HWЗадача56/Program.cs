// Задайте прямоугольный двумерный массив. Напишите программу,
 // которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите размер массива a на b и неотрицаткльные числа:");
int a = EnterNumbers("Введите a: ");
int b = EnterNumbers("Введите b: ");
int num = EnterNumbers("Введите числа: от 1 до ");

int[,] array = new int[a, b];
DoArray(array);
EnterArray(array);

int minSummRow = 0;
int summRow = SummRowElements(array, 0);
for (int x = 1; x < array.GetLength(0); x ++)
{
  int tempSummRow = SummRowElements(array, x);
  if (summRow > tempSummRow)
  {
    summRow = tempSummRow;
    minSummRow = x;
  }
}
Console.WriteLine($"\a{minSummRow +1} - ряд с наименьшей суммой ({summRow}) элементов ");
int SummRowElements(int[,] array, int x)
{
  int summRow = array[x, 0];
  for (int y = 1; y < array.GetLength(1); y ++)
  {
    summRow += array[x, y];
  }
  return summRow;
}
int EnterNumbers(string enter)
{
  Console.Write(enter);
  int rezult = Convert.ToInt32(Console.ReadLine());
  return rezult;
}
void DoArray(int[,] array)
{
  for (int x = 0; x < array.GetLength(0); x ++)
  {
    for (int y = 0; y < array.GetLength(1); y ++)
    {
      array[x, y] = new Random().Next(num);
    }
  }
}
void EnterArray (int[,] array)
{
  for (int x = 0; x < array.GetLength(0); x ++)
  {
    for (int y = 0; y < array.GetLength(1); y ++)
    {
      Console.Write(array[x, y] + " ");
    }
    Console.WriteLine();
  }
}


