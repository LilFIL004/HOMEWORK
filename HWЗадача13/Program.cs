// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третей цифры нет.
// 645 -> 5
// 78 -> 8 третей цифры нет
// 32679 -> 6

Console.WriteLine("Введите любое не однозначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 100 && num <= 999)
{
    int number = num % 10;
    Console.WriteLine("Третья цифра: " + number);
}
if (num < 100)
{
    Console.WriteLine("Третьей цифры не существует ");
}
else if (num > 999)
{
    while (num > 999)
    num = num /10;
    int number2 = num % 10;
    Console.WriteLine("Третья цифра:" + number2);
}