// Напишите цикл, который принимает на вход два числа (A и B) и выводит число Aв натуральную степень B.
// 3, 5 -> 249(3^5)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (numvstepeni(a, b));
double numvstepeni(int a, int b)
{
    return Math.Pow(a, b);
}