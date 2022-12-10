// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите любое не однозначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр {num} = {SumIzNumbers(num)}");
int SumIzNumbers(int a)
{
    int result = 0;
    while (a > 10)
    {
        result += a % 10;
        a = a / 10;
    }
    if (a < 10)
    {
        result += a;
    }
    return result;
}
