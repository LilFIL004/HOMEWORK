// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = EnterNumber("Введите значение M: ");
int n = EnterNumber("Введите значение N: ");
int pace = m;
if (m > n) 
{
  m = n; 
  n = pace;
}
PechatSum(m, n, pace = 0);
void PechatSum(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма натуральных элементов = {sum} ");
    return;
  }
  PechatSum(m, n - 1, sum);
}

int EnterNumber(string enter) 
{
  Console.Write(enter);
  int rezult = Convert.ToInt32(Console.ReadLine());
  return rezult;
}
