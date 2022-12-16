// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
DoArrayRandomNum(num);
Console.WriteLine("массив: ");
PechatArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < num.Length; i ++)
{
    if (num[i] > max)
        {
            max = num[i];
        }
    if (num[i] < min)
        {
            min = num[i];
        }
}
Console.WriteLine($"Итого {num.Length} чисел. MAX значение = {max}, MIN значение = {min}");
Console.WriteLine($"Разница между MAX и MIN значениями = {max - min}");
void DoArrayRandomNum(double[] numbers)
{
    for(int b = 0; b < num.Length; b ++)
        {
            num[b] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PechatArray(double[] num)
{
    Console.WriteLine(" ");
    for(int i = 0; i < num.Length; i ++)
        {
            Console.Write(num[i] + " ");
        }
    Console.WriteLine(" ");
    Console.WriteLine();
}    