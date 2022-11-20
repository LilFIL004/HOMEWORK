// Напишите программу, которая принимает на вход три числа и выдаёт максимальное их этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22 

Console.Write("Введите первое число ");
int num1 =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int num2 =Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число ");
int num3 =Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 > num3)
    {
        Console.Write("Максимальным числом является num1");
    }
    else
    {
         Console.Write("Максимальным числом является num3");
    }
}
else if (num2 > num3)
{
    Console.Write("Максимальным числом является num2");
}
else
{
    Console.Write("Максимальным числом является num3");
}