// Напишите программу, которая на входе принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int rez = 2;
while( rez < num)
{
    Console.Write(rez);
    rez = rez + 2;
}





