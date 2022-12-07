// Напишите программу, которая принимает на вход число(N) и выдаёт таблицу кубов чисел oт 1 до N
// 3 -> 1,4,9
// 5 -> 1,8,27,64,125

Console.WriteLine("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());
for (int a = 1; a <= num; a  ++)
{
    Console.WriteLine($"Исходное число: {a}");
    Console.WriteLine($"Возведённое число в куб: {Math.Pow(a, 3)}");
}
