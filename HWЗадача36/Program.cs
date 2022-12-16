// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [4]; 
DoArray(array);
Console.WriteLine(" ");
SumArray(array);
void SumArray (int [] array)
{
    int sum = 0; 
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
     Console.WriteLine($"Сумма эдементов, стоящих на нечётных позициях {sum}");
}

void DoArray (int [] array)
{
     for (int i = 0; i < array.Length; i ++) 
     {
        array[i] = new Random().Next(1, 99);
        Console.Write($"{array[i]} ");
     }
}