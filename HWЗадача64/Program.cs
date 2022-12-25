// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Введите число больше 5:");

int n = EnterNumbers("Введите значение N: ");
int count = 2;
PechatNumber(n, count);
Console.Write(1);
void PechatNumber(int n, int count)
{
  if (count > n) return;
  PechatNumber(n, count + 1);
  Console.Write(count + ", ");
}
int EnterNumbers(string input) 
{
  Console.Write(input);
  int rezult = Convert.ToInt32(Console.ReadLine());
  return rezult;
}
